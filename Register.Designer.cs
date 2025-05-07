using System.ComponentModel;

namespace LRS;

partial class Register
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Register));
        emailbox = new TextBox();
        emailLabel = new Label();
        psdBox = new TextBox();
        psdLabel = new Label();
        usernameLabel = new Label();
        nameBox = new TextBox();
        label1 = new Label();
        confirmBox = new TextBox();
        regButton = new Button();
        loginButton = new Button();
        SuspendLayout();
        // 
        // emailbox
        // 
        emailbox.Location = new Point(197, 182);
        emailbox.Name = "emailbox";
        emailbox.Size = new Size(341, 38);
        emailbox.TabIndex = 4;
        // 
        // emailLabel
        // 
        emailLabel.AutoSize = true;
        emailLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
        emailLabel.Location = new Point(101, 177);
        emailLabel.Name = "emailLabel";
        emailLabel.Size = new Size(90, 41);
        emailLabel.TabIndex = 2;
        emailLabel.Text = "邮箱:";
        // 
        // psdBox
        // 
        psdBox.Location = new Point(197, 275);
        psdBox.Name = "psdBox";
        psdBox.PasswordChar = '*';
        psdBox.Size = new Size(341, 38);
        psdBox.TabIndex = 5;
        // 
        // psdLabel
        // 
        psdLabel.AutoSize = true;
        psdLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
        psdLabel.Location = new Point(101, 270);
        psdLabel.Name = "psdLabel";
        psdLabel.Size = new Size(90, 41);
        psdLabel.TabIndex = 3;
        psdLabel.Text = "密码:";
        // 
        // usernameLabel
        // 
        usernameLabel.AutoSize = true;
        usernameLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
        usernameLabel.Location = new Point(69, 88);
        usernameLabel.Name = "usernameLabel";
        usernameLabel.Size = new Size(122, 41);
        usernameLabel.TabIndex = 2;
        usernameLabel.Text = "用户名:";
        // 
        // nameBox
        // 
        nameBox.Location = new Point(197, 93);
        nameBox.Name = "nameBox";
        nameBox.Size = new Size(341, 38);
        nameBox.TabIndex = 4;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label1.Location = new Point(37, 366);
        label1.Name = "label1";
        label1.Size = new Size(154, 41);
        label1.TabIndex = 3;
        label1.Text = "确认密码:";
        // 
        // confirmBox
        // 
        confirmBox.Location = new Point(197, 371);
        confirmBox.Name = "confirmBox";
        confirmBox.PasswordChar = '*';
        confirmBox.Size = new Size(341, 38);
        confirmBox.TabIndex = 5;
        // 
        // regButton
        // 
        regButton.Location = new Point(136, 447);
        regButton.Name = "regButton";
        regButton.Size = new Size(151, 65);
        regButton.TabIndex = 6;
        regButton.Text = "注册";
        regButton.UseVisualStyleBackColor = true;
        regButton.Click += regButton_Click;
        // 
        // loginButton
        // 
        loginButton.Location = new Point(327, 447);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(151, 65);
        loginButton.TabIndex = 7;
        loginButton.Text = "登录";
        loginButton.UseVisualStyleBackColor = true;
        loginButton.Click += loginButton_Click;
        // 
        // Register
        // 
        AutoScaleDimensions = new SizeF(14F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(590, 573);
        Controls.Add(regButton);
        Controls.Add(loginButton);
        Controls.Add(nameBox);
        Controls.Add(usernameLabel);
        Controls.Add(emailbox);
        Controls.Add(emailLabel);
        Controls.Add(confirmBox);
        Controls.Add(label1);
        Controls.Add(psdBox);
        Controls.Add(psdLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        Name = "Register";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "湘潭大学图书馆预约系统 注册";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox emailbox;
    private Label emailLabel;
    private TextBox psdBox;
    private Label psdLabel;
    private Label usernameLabel;
    private TextBox nameBox;
    private Label label1;
    private TextBox confirmBox;
    private Button regButton;
    private Button loginButton;
}