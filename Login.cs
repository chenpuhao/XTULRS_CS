using System.Runtime.InteropServices;
using System.Text.Json;

namespace LRS;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int IsAdmin { get; set; }
        public string Seat { get; set; }
    }

    public User UserInfo;
    public int Logined;

    public static IntPtr LoginUser;
    private void loginButton_Click(object sender, EventArgs e)
    {
        string email = emailbox.Text;
        string password = Encryption.Encrypt(psdBox.Text);

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("邮箱和密码不能为空");
            return;
        }

        LoginUser = Dll.login(Program.UserHead, Marshal.StringToHGlobalAnsi(email),
            Marshal.StringToHGlobalAnsi(password));
        if (LoginUser == IntPtr.Zero)
        {
            MessageBox.Show("登录失败，请检查邮箱和密码");
            return;
        }

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        IntPtr userInfo = Dll.getUserInfo(LoginUser);
        string userInfoJson = Marshal.PtrToStringAnsi(userInfo);
        UserInfo = JsonSerializer.Deserialize<User>(userInfoJson,options);
        Logined = 1;
        Close();
    }

    private void regButton_Click(object sender, EventArgs e)
    {
        using (var register = new Register())
        {
            register.ShowDialog();
        }
    }
}