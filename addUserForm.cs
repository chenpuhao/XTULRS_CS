using System.Runtime.InteropServices;

namespace LRS;

public partial class addUserForm : Form
{
    public addUserForm()
    {
        InitializeComponent();
    }

    private void confirm_Click(object sender, EventArgs e)
    {
        string name = usernameBox.Text;
        string email = emailBox.Text;
        string password = passwordBox.Text;
        int isAdmin = comboBox.SelectedItem.Equals("是") ? 1 : 0;
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("所有字段都不能为空");
            return;
        }

        if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            MessageBox.Show("邮箱格式不正确");
            return;
        }

        if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z]+$"))
        {
            MessageBox.Show("用户名只能包含字母");
            return;
        }

        if (!System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d]{8,}$"))
        {
            MessageBox.Show("密码必须包含字母和数字，并且至少8位");
            return;
        }

        string encryptedPassword = Encryption.Encrypt(password);

        IntPtr namePtr = Marshal.StringToHGlobalAnsi(name);
        IntPtr emailPtr = Marshal.StringToHGlobalAnsi(email);
        IntPtr passwordPtr = Marshal.StringToHGlobalAnsi(encryptedPassword);

        if (Dll.addUser(Program.UserHead, namePtr, emailPtr, passwordPtr, isAdmin, IntPtr.Zero) != 0)
        {
            MessageBox.Show("注册失败，请检查邮箱和密码");
            return;
        }

        Dll.saveUser(Program.UserHead);

        MessageBox.Show("注册成功");
        Close();
    }

    private void addUserForm_Load(object sender, EventArgs e)
    {
        comboBox.Items.Add("是");
        comboBox.Items.Add("否");
        comboBox.SelectedIndex = 1;
    }
}