
namespace LRS;

static class Program
{
    public static IntPtr UserHead = Dll.getUserHead();
    public static IntPtr SeatHead = Dll.getSeatHead();
    public static IntPtr StatisticHead = Dll.getStatisticHead();
    public static string Username = "";
    public static string UserEmail = "";
    public static string Seat = "";

    [STAThread]
    static void Main()
    {
        if (Dll.test() != 123)
        {
            MessageBox.Show("DLL加载失败，请检查资源文件是否完整");
            return;
        }

        Dll.loadUser(UserHead);
        Dll.loadSeat(SeatHead);
        Dll.loadStatistic(StatisticHead);
        ApplicationConfiguration.Initialize();

        using (var welcome = new Welcome())
        {
            welcome.Show();
            Task.Delay(3000).Wait();
        }

        Login login = new Login();
        login.ShowDialog(); 

        if (login.Logined != 1)
        {
            return;
        }
        Username = login.UserInfo.Name;
        UserEmail = login.UserInfo.Email;
        if (!string.IsNullOrEmpty(login.UserInfo.Seat))
        {
            Seat = login.UserInfo.Seat;
        }
        else
        {
            Seat = "none";
        }
        if (login.UserInfo.IsAdmin == 0)
        {
            Application.Run(new User());
        }
        else
        {
            Application.Run(new Admin());
        }
        //持续监控login.Logined，如果变成0，弹出登录框
        
    }
}