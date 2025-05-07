using System.Runtime.InteropServices;
using System.Text.Json;

namespace LRS;

public partial class User : Form
{
    public class Reservation
    {
        public int room { get; set; }
        public int seat { get; set; }
    }

    public class Seats
    {
        public int Room { get; set; }
        public int Seat { get; set; }
        public int IsOccupied { get; set; }
    }

    public User()
    {
        InitializeComponent();
    }

    private void User_Load(object sender, EventArgs e)
    {
        welcomeLabel.Text = "你好，" + Program.Username;
        if (Program.Seat == "none")
        {
            reservation.Text = "你当前没有预约座位哦，快去预约吧！";
        }
        else
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            Reservation res = JsonSerializer.Deserialize<Reservation>(Program.Seat, options);
            reservation.Text = "你当前预约的座位是" + res.room + "的" + res.seat + "号";
        }

        dataGridView1.Columns.Add("Room", "房间号");
        dataGridView1.Columns.Add("Seat", "座位号");
        dataGridView1.Columns.Add("isOccupied", "是否被占用");

        string seatsJson = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
        if (!string.IsNullOrEmpty(seatsJson))
        {
            AddData(seatsJson);

            if (Program.Seat == "none")
            {
                res.Enabled = true;
                cancel.Enabled = false;
            }
            else
            {
                res.Enabled = false;
                cancel.Enabled = true;
            }
        }
        PopulateComboBoxes();

    }

    private void res_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedCells.Count > 0)
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            int room = Convert.ToInt32(selectedRow.Cells["Room"].Value);
            int seat = Convert.ToInt32(selectedRow.Cells["Seat"].Value);
            if (Dll.reserveSeat(Program.SeatHead, room, seat, Login.LoginUser, Program.StatisticHead) == 0)
            {
                MessageBox.Show("预约成功");
                Program.Seat = JsonSerializer.Serialize(new Reservation { room = room, seat = seat });
                reservation.Text = "你当前预约的座位是" + room + "的" + seat + "号";
                res.Enabled = false;
                cancel.Enabled = true;
                Dll.saveSeats(Program.SeatHead);
                Dll.saveStatistic(Program.StatisticHead);
                Dll.saveUser(Program.UserHead);
                string seatsJson = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
                if (!string.IsNullOrEmpty(seatsJson))
                {
                    AddData(seatsJson);
                }
            }
            else
            {
                MessageBox.Show("预约失败，请检查座位是否已被占用");
            }
        }
        else
        {
            MessageBox.Show("你还没有选择座位哦，单击表格任意一行可以选择该座位");
        }
    }
    private void cancel_Click(object sender, EventArgs e)
    {
        if (Dll.cancelReservation(Program.SeatHead, Login.LoginUser) == 0)
        {
            MessageBox.Show("取消预约成功");
            Program.Seat = "none";
            reservation.Text = "你当前没有预约座位哦，快去预约吧！";
            res.Enabled = true;
            cancel.Enabled = false;
            Dll.saveSeats(Program.SeatHead);
            Dll.saveUser(Program.UserHead);
            string seatsJson = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
            if (!string.IsNullOrEmpty(seatsJson))
            {
                AddData(seatsJson);
            }
        }
        else
        {
            MessageBox.Show("取消预约失败，请检查座位是否已被占用");
        }
    }
    private void AddData(string seatsJson)
    {
        dataGridView1.Rows.Clear();
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        // 直接反序列化为 List<Seats>
        var seatsList = JsonSerializer.Deserialize<List<Seats>>(seatsJson, options);
        if (seatsList != null)
        {
            foreach (var seat in seatsList)
            {
                // 添加数据到表格
                dataGridView1.Rows.Add(seat.Room, seat.Seat, seat.IsOccupied == 1 ? "被占用" : "空闲");
            }
        }
    }
    private void PopulateComboBoxes()
    {
        // 清空下拉框
        roomNum.Items.Clear();
        seatNum.Items.Clear();
        isFree.Items.Clear();

        // 添加是否空闲选项
        isFree.Items.Add("空闲");
        isFree.Items.Add("被占用");

        // 获取座位数据
        string seatsJson = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
        if (!string.IsNullOrEmpty(seatsJson))
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            // 反序列化座位数据
            var seatsList = JsonSerializer.Deserialize<List<Seats>>(seatsJson, options);
            if (seatsList != null)
            {
                // 使用 HashSet 去重
                var roomSet = new HashSet<int>();
                var seatSet = new HashSet<int>();

                foreach (var seat in seatsList)
                {
                    roomSet.Add(seat.Room);
                    seatSet.Add(seat.Seat);
                }

                foreach (var room in roomSet)
                {
                    roomNum.Items.Add(room);
                }

                foreach (var seat in seatSet)
                {
                    seatNum.Items.Add(seat);
                }
            }
        }
    }

    private void button_Click(object sender, EventArgs e)
    {
        IntPtr rooms = Dll.returnAllSeats(Program.SeatHead);
        string roomsJson = Marshal.PtrToStringAnsi(rooms);
        if (roomNum.SelectedItem != null)
        {
            int selectedRoom = (int)roomNum.SelectedItem;
            IntPtr temp = Dll.findSeatByRoom(Program.SeatHead, selectedRoom);
            string seatsJson = Marshal.PtrToStringAnsi(temp);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var allSeats = JsonSerializer.Deserialize<List<Seats>>(roomsJson, options);
            var filteredSeats = JsonSerializer.Deserialize<List<Seats>>(seatsJson, options);

            if (allSeats != null && filteredSeats != null)
            {
                var commonSeats = allSeats.Where(seat =>
                    filteredSeats.Any(filtered =>
                        filtered.Room == seat.Room && filtered.Seat == seat.Seat)).ToList();

                // 将筛选后的片段重新序列化为 JSON
                roomsJson = JsonSerializer.Serialize(commonSeats);
                AddData(roomsJson);
            }
        }

        if (seatNum.SelectedItem != null)
        {
            int selectedSeat = (int)seatNum.SelectedItem;
            IntPtr temp = Dll.findSeatBySeat(Program.SeatHead, selectedSeat);
            string seatsJson = Marshal.PtrToStringAnsi(temp);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var allSeats = JsonSerializer.Deserialize<List<Seats>>(roomsJson, options);
            var filteredSeats = JsonSerializer.Deserialize<List<Seats>>(seatsJson, options);

            if (allSeats != null && filteredSeats != null)
            {
                var commonSeats = allSeats.Where(seat =>
                    filteredSeats.Any(filtered =>
                        filtered.Room == seat.Room && filtered.Seat == seat.Seat)).ToList();

                // 将筛选后的片段重新序列化为 JSON
                roomsJson = JsonSerializer.Serialize(commonSeats);
                AddData(roomsJson);
            }
        }

        if (isFree.SelectedItem != null)
        {
            string selectedIsFree = (string)isFree.SelectedItem;
            IntPtr temp = Dll.findSeatByIsOccupied(Program.SeatHead, selectedIsFree == "空闲" ? 0 : 1);
            string seatsJson = Marshal.PtrToStringAnsi(temp);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var allSeats = JsonSerializer.Deserialize<List<Seats>>(roomsJson, options);
            var filteredSeats = JsonSerializer.Deserialize<List<Seats>>(seatsJson, options);

            if (allSeats != null && filteredSeats != null)
            {
                var commonSeats = allSeats.Where(seat =>
                    filteredSeats.Any(filtered =>
                        filtered.Room == seat.Room && filtered.Seat == seat.Seat)).ToList();

                // 将筛选后的片段重新序列化为 JSON
                roomsJson = JsonSerializer.Serialize(commonSeats);
                AddData(roomsJson);
            }
        }
    }
    private void removeButton_Click(object sender, EventArgs e)
    {
        roomNum.SelectedItem = null;
        seatNum.SelectedItem = null;
        isFree.SelectedItem = null;
        string seatsJson = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
        if (!string.IsNullOrEmpty(seatsJson))
        {
            AddData(seatsJson);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        using (var userInfo = new Info())
        {
            userInfo.ShowDialog();
        }
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("确定要退出吗？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            Dll.saveSeats(Program.SeatHead);
            Dll.saveUser(Program.UserHead);
            Dll.saveStatistic(Program.StatisticHead);
            Dll.freeSeat(Program.SeatHead);
            Dll.freeUser(Program.UserHead);
            Dll.freeStatistic(Program.StatisticHead);
            Application.Exit();
        }
    }
}