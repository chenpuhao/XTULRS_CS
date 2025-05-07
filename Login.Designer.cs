using System.ComponentModel;

namespace LRS;

partial class Login
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Login));
        psdLabel = new Label();
        emailLabel = new Label();
        emailbox = new TextBox();
        loginButton = new Button();
        psdBox = new TextBox();
        regButton = new Button();
        SuspendLayout();
        // 
        // psdLabel
        // 
        psdLabel.AutoSize = true;
        psdLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
        psdLabel.Location = new Point(128, 186);
        psdLabel.Name = "psdLabel";
        psdLabel.Size = new Size(90, 41);
        psdLabel.TabIndex = 0;
        psdLabel.Text = "密码:";
        // 
        // emailLabel
        // 
        emailLabel.AutoSize = true;
        emailLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
        emailLabel.Location = new Point(128, 93);
        emailLabel.Name = "emailLabel";
        emailLabel.Size = new Size(90, 41);
        emailLabel.TabIndex = 0;
        emailLabel.Text = "邮箱:";
        // 
        // emailbox
        // 
        emailbox.Location = new Point(224, 98);
        emailbox.Name = "emailbox";
        emailbox.Size = new Size(341, 38);
        emailbox.TabIndex = 1;
        // 
        // loginButton
        // 
        loginButton.Location = new Point(190, 283);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(151, 65);
        loginButton.TabIndex = 2;
        loginButton.Text = "登录";
        loginButton.UseVisualStyleBackColor = true;
        loginButton.Click += loginButton_Click;
        // 
        // psdBox
        // 
        psdBox.Location = new Point(224, 191);
        psdBox.Name = "psdBox";
        psdBox.PasswordChar = '*';
        psdBox.Size = new Size(341, 38);
        psdBox.TabIndex = 1;
        // 
        // regButton
        // 
        regButton.Location = new Point(377, 283);
        regButton.Name = "regButton";
        regButton.Size = new Size(151, 65);
        regButton.TabIndex = 2;
        regButton.Text = "注册";
        regButton.UseVisualStyleBackColor = true;
        regButton.Click += regButton_Click;
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(14F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(697, 425);
        Controls.Add(regButton);
        Controls.Add(loginButton);
        Controls.Add(emailbox);
        Controls.Add(emailLabel);
        Controls.Add(psdBox);
        Controls.Add(psdLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "Login";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "湘潭大学图书馆预约系统 登录";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label psdLabel;
    private Label emailLabel;
    private TextBox emailbox;
    private Button loginButton;
    private TextBox psdBox;
    private Button regButton;
}