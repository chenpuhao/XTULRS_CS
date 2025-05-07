using System.ComponentModel;

namespace LRS;

partial class Info
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Info));
        username = new Label();
        email = new Label();
        changeUsername = new Button();
        changepsd = new Button();
        SuspendLayout();
        // 
        // username
        // 
        username.AutoSize = true;
        username.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
        username.Location = new Point(43, 69);
        username.Name = "username";
        username.Size = new Size(304, 41);
        username.TabIndex = 0;
        username.Text = "用户名: {username}";
        // 
        // email
        // 
        email.AutoSize = true;
        email.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
        email.Location = new Point(43, 149);
        email.Name = "email";
        email.Size = new Size(205, 41);
        email.TabIndex = 0;
        email.Text = "邮箱: {email}";
        // 
        // changeUsername
        // 
        changeUsername.Location = new Point(153, 219);
        changeUsername.Name = "changeUsername";
        changeUsername.Size = new Size(150, 46);
        changeUsername.TabIndex = 1;
        changeUsername.Text = "修改用户名";
        changeUsername.UseVisualStyleBackColor = true;
        changeUsername.Click += changeUsername_Click;
        // 
        // changepsd
        // 
        changepsd.Location = new Point(343, 219);
        changepsd.Name = "changepsd";
        changepsd.Size = new Size(150, 46);
        changepsd.TabIndex = 1;
        changepsd.Text = "修改密码";
        changepsd.UseVisualStyleBackColor = true;
        changepsd.Click += changepsd_Click;
        // 
        // Info
        // 
        AutoScaleDimensions = new SizeF(14F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(676, 318);
        Controls.Add(changepsd);
        Controls.Add(changeUsername);
        Controls.Add(email);
        Controls.Add(username);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "Info";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "湘潭大学图书馆预约系统 我的信息";
        Load += Info_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label username;
    private Label email;
    private Button changeUsername;
    private Button changepsd;
}