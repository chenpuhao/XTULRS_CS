using LRS;

namespace LRS;

public partial class addSeatForm : Form
{
    public addSeatForm()
    {
        InitializeComponent();
    }

    private void confirm_Click(object sender, EventArgs e)
    {
        string room = roomBox.Text;
        string seat = seatBox.Text;
        if (string.IsNullOrEmpty(room) || string.IsNullOrEmpty(seat))
        {
            MessageBox.Show("所有字段都不能为空");
            return;
        }
        if (!int.TryParse(room, out int roomNum) || !int.TryParse(seat, out int seatNum))
        {
            MessageBox.Show("房间号和座位号必须是数字");
            return;
        }
        int roomInt = int.Parse(roomBox.Text);
        int seatInt = int.Parse(seatBox.Text);
        if (Dll.addSeat(Program.SeatHead, roomInt, seatInt,0) != 0)
        {
            MessageBox.Show("添加失败，请检查房间号和座位号");
            return;
        }
        Dll.saveSeats(Program.SeatHead);
        MessageBox.Show("添加成功");
        Close();
    }
}