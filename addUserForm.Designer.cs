using System.ComponentModel;

namespace LRS;

partial class addUserForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        ComponentResourceManager resources = new ComponentResourceManager(typeof(addUserForm));
        username = new Label();
        usernameBox = new TextBox();
        email = new Label();
        emailBox = new TextBox();
        password = new Label();
        passwordBox = new TextBox();
        confirm = new Button();
        label1 = new Label();
        comboBox = new ComboBox();
        SuspendLayout();
        // 
        // username
        // 
        username.AutoSize = true;
        username.Location = new Point(101, 81);
        username.Name = "username";
        username.Size = new Size(110, 31);
        username.TabIndex = 0;
        username.Text = "用户名：";
        // 
        // usernameBox
        // 
        usernameBox.Location = new Point(217, 78);
        usernameBox.Name = "usernameBox";
        usernameBox.Size = new Size(442, 38);
        usernameBox.TabIndex = 1;
        // 
        // email
        // 
        email.AutoSize = true;
        email.Location = new Point(125, 144);
        email.Name = "email";
        email.Size = new Size(86, 31);
        email.TabIndex = 0;
        email.Text = "邮箱：";
        // 
        // emailBox
        // 
        emailBox.Location = new Point(217, 141);
        emailBox.Name = "emailBox";
        emailBox.Size = new Size(442, 38);
        emailBox.TabIndex = 1;
        // 
        // password
        // 
        password.AutoSize = true;
        password.Location = new Point(125, 215);
        password.Name = "password";
        password.Size = new Size(86, 31);
        password.TabIndex = 0;
        password.Text = "密码：";
        // 
        // passwordBox
        // 
        passwordBox.Location = new Point(217, 212);
        passwordBox.Name = "passwordBox";
        passwordBox.PasswordChar = '*';
        passwordBox.Size = new Size(442, 38);
        passwordBox.TabIndex = 1;
        // 
        // confirm
        // 
        confirm.Location = new Point(321, 355);
        confirm.Name = "confirm";
        confirm.Size = new Size(150, 46);
        confirm.TabIndex = 2;
        confirm.Text = "确定";
        confirm.UseVisualStyleBackColor = true;
        confirm.Click += confirm_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(53, 281);
        label1.Name = "label1";
        label1.Size = new Size(158, 31);
        label1.TabIndex = 0;
        label1.Text = "是否管理员：";
        // 
        // comboBox
        // 
        comboBox.FormattingEnabled = true;
        comboBox.Location = new Point(217, 278);
        comboBox.Name = "comboBox";
        comboBox.Size = new Size(242, 39);
        comboBox.TabIndex = 3;
        // 
        // addUserForm
        // 
        AutoScaleDimensions = new SizeF(14F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 441);
        Controls.Add(comboBox);
        Controls.Add(confirm);
        Controls.Add(passwordBox);
        Controls.Add(label1);
        Controls.Add(password);
        Controls.Add(emailBox);
        Controls.Add(email);
        Controls.Add(usernameBox);
        Controls.Add(username);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        Name = "addUserForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "湘潭大学图书馆预约系统 新增用户";
        Load += addUserForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label username;
    private TextBox usernameBox;
    private Label email;
    private TextBox emailBox;
    private Label password;
    private TextBox passwordBox;
    private Button confirm;
    private Label label1;
    private ComboBox comboBox;
}