using System.ComponentModel;

namespace LRS;

partial class User
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(User));
        welcomeLabel = new Label();
        button1 = new Button();
        reservation = new Label();
        dataGridView1 = new DataGridView();
        cancel = new Button();
        res = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        isFree = new ComboBox();
        seatNum = new ComboBox();
        roomNum = new ComboBox();
        removeButton = new Button();
        button = new Button();
        exitButton = new Button();
        ((ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // welcomeLabel
        // 
        welcomeLabel.AutoSize = true;
        welcomeLabel.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
        welcomeLabel.Location = new Point(12, 9);
        welcomeLabel.Name = "welcomeLabel";
        welcomeLabel.Size = new Size(206, 48);
        welcomeLabel.TabIndex = 0;
        welcomeLabel.Text = "你好，user";
        // 
        // button1
        // 
        button1.Font = new Font("Microsoft YaHei UI", 9F);
        button1.Location = new Point(1407, 9);
        button1.Name = "button1";
        button1.Size = new Size(140, 58);
        button1.TabIndex = 1;
        button1.Text = "我的信息";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // reservation
        // 
        reservation.AutoSize = true;
        reservation.Font = new Font("Microsoft YaHei UI", 13.875F);
        reservation.Location = new Point(529, 9);
        reservation.Name = "reservation";
        reservation.Size = new Size(618, 48);
        reservation.TabIndex = 2;
        reservation.Text = "你当前已经预约了{room} {seat}座位";
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.AllowUserToResizeColumns = false;
        dataGridView1.AllowUserToResizeRows = false;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.BackgroundColor = SystemColors.Window;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(12, 156);
        dataGridView1.MultiSelect = false;
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RowHeadersWidth = 82;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
        dataGridView1.Size = new Size(1681, 889);
        dataGridView1.TabIndex = 3;
        // 
        // cancel
        // 
        cancel.Location = new Point(597, 1070);
        cancel.Name = "cancel";
        cancel.Size = new Size(255, 60);
        cancel.TabIndex = 4;
        cancel.Text = "取消预约";
        cancel.UseVisualStyleBackColor = true;
        cancel.Click += cancel_Click;
        // 
        // res
        // 
        res.Location = new Point(892, 1070);
        res.Name = "res";
        res.Size = new Size(255, 60);
        res.TabIndex = 4;
        res.Text = "预约";
        res.UseVisualStyleBackColor = true;
        res.Click += res_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 104);
        label1.Name = "label1";
        label1.Size = new Size(92, 31);
        label1.TabIndex = 5;
        label1.Text = "房间号:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(915, 104);
        label2.Name = "label2";
        label2.Size = new Size(116, 31);
        label2.TabIndex = 5;
        label2.Text = "是否空闲:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(454, 104);
        label3.Name = "label3";
        label3.Size = new Size(92, 31);
        label3.TabIndex = 5;
        label3.Text = "座位号:";
        // 
        // isFree
        // 
        isFree.FormattingEnabled = true;
        isFree.Location = new Point(1037, 104);
        isFree.Name = "isFree";
        isFree.Size = new Size(301, 39);
        isFree.TabIndex = 7;
        // 
        // seatNum
        // 
        seatNum.FormattingEnabled = true;
        seatNum.Location = new Point(552, 104);
        seatNum.Name = "seatNum";
        seatNum.Size = new Size(321, 39);
        seatNum.TabIndex = 8;
        // 
        // roomNum
        // 
        roomNum.FormattingEnabled = true;
        roomNum.Location = new Point(110, 104);
        roomNum.Name = "roomNum";
        roomNum.Size = new Size(307, 39);
        roomNum.TabIndex = 9;
        // 
        // removeButton
        // 
        removeButton.Location = new Point(1531, 99);
        removeButton.Name = "removeButton";
        removeButton.Size = new Size(150, 46);
        removeButton.TabIndex = 10;
        removeButton.Text = "清除筛选";
        removeButton.UseVisualStyleBackColor = true;
        removeButton.Click += removeButton_Click;
        // 
        // button
        // 
        button.Location = new Point(1363, 99);
        button.Name = "button";
        button.Size = new Size(150, 46);
        button.TabIndex = 10;
        button.Text = "筛选";
        button.UseVisualStyleBackColor = true;
        button.Click += button_Click;
        // 
        // exitButton
        // 
        exitButton.Font = new Font("Microsoft YaHei UI", 9F);
        exitButton.Location = new Point(1553, 9);
        exitButton.Name = "exitButton";
        exitButton.Size = new Size(140, 58);
        exitButton.TabIndex = 1;
        exitButton.Text = "退出系统";
        exitButton.UseVisualStyleBackColor = true;
        exitButton.Click += exitButton_Click;
        // 
        // User
        // 
        AutoScaleDimensions = new SizeF(14F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1705, 1142);
        Controls.Add(removeButton);
        Controls.Add(button);
        Controls.Add(roomNum);
        Controls.Add(seatNum);
        Controls.Add(isFree);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(res);
        Controls.Add(cancel);
        Controls.Add(dataGridView1);
        Controls.Add(reservation);
        Controls.Add(exitButton);
        Controls.Add(button1);
        Controls.Add(welcomeLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "User";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "湘潭大学图书馆预约系统 用户端";
        Load += User_Load;
        ((ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label welcomeLabel;
    private Button button1;
    private Label reservation;
    private DataGridView dataGridView1;
    private Button cancel;
    private Button res;
    private Label label1;
    private Label label2;
    private Label label3;
    private ComboBox isFree;
    private ComboBox seatNum;
    private ComboBox roomNum;
    private Button removeButton;
    private Button button;
    private Button exitButton;
}