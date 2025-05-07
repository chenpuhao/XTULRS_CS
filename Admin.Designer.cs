using System.ComponentModel;

namespace LRS;

partial class Admin
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Admin));
        seatData = new TabControl();
        tabPage1 = new TabPage();
        clearSeats = new Button();
        setUser = new Button();
        setAdmin = new Button();
        delUser = new Button();
        newUser = new Button();
        changePassword = new Button();
        changeUsername = new Button();
        userDataBox = new DataGridView();
        tabPage2 = new TabPage();
        cancelSeat = new Button();
        button1 = new Button();
        button2 = new Button();
        roomNum = new ComboBox();
        seatNum = new ComboBox();
        isFree = new ComboBox();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        exportSeats = new Button();
        importSeat = new Button();
        removeSeat = new Button();
        addSeat = new Button();
        seatDataBox = new DataGridView();
        tabPage3 = new TabPage();
        label10 = new Label();
        exportAsExcel = new Button();
        exportAsJson = new Button();
        label9 = new Label();
        checkBox1 = new CheckBox();
        removeButton = new Button();
        button = new Button();
        dateTimeEnd = new DateTimePicker();
        dateTimeStart = new DateTimePicker();
        userRes = new ComboBox();
        label8 = new Label();
        label4 = new Label();
        label2 = new Label();
        seatRes = new ComboBox();
        label3 = new Label();
        roomRes = new ComboBox();
        label1 = new Label();
        clearSat = new Button();
        removeSat = new Button();
        resDataBox = new DataGridView();
        info = new Label();
        refresh = new Button();
        exitButton = new Button();
        seatData.SuspendLayout();
        tabPage1.SuspendLayout();
        ((ISupportInitialize)userDataBox).BeginInit();
        tabPage2.SuspendLayout();
        ((ISupportInitialize)seatDataBox).BeginInit();
        tabPage3.SuspendLayout();
        ((ISupportInitialize)resDataBox).BeginInit();
        SuspendLayout();
        // 
        // seatData
        // 
        seatData.Controls.Add(tabPage1);
        seatData.Controls.Add(tabPage2);
        seatData.Controls.Add(tabPage3);
        seatData.Location = new Point(-2, 109);
        seatData.Name = "seatData";
        seatData.SelectedIndex = 0;
        seatData.Size = new Size(1708, 1035);
        seatData.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(clearSeats);
        tabPage1.Controls.Add(setUser);
        tabPage1.Controls.Add(setAdmin);
        tabPage1.Controls.Add(delUser);
        tabPage1.Controls.Add(newUser);
        tabPage1.Controls.Add(changePassword);
        tabPage1.Controls.Add(changeUsername);
        tabPage1.Controls.Add(userDataBox);
        tabPage1.Location = new Point(8, 45);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(1692, 982);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "用户管理";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // clearSeats
        // 
        clearSeats.Location = new Point(1397, 918);
        clearSeats.Name = "clearSeats";
        clearSeats.Size = new Size(206, 64);
        clearSeats.TabIndex = 2;
        clearSeats.Text = "清除座位预约";
        clearSeats.UseVisualStyleBackColor = true;
        clearSeats.Click += clearSeats_Click;
        // 
        // setUser
        // 
        setUser.Location = new Point(1167, 918);
        setUser.Name = "setUser";
        setUser.Size = new Size(206, 64);
        setUser.TabIndex = 2;
        setUser.Text = "设为用户";
        setUser.UseVisualStyleBackColor = true;
        setUser.Click += setUser_Click;
        // 
        // setAdmin
        // 
        setAdmin.Location = new Point(937, 918);
        setAdmin.Name = "setAdmin";
        setAdmin.Size = new Size(206, 64);
        setAdmin.TabIndex = 1;
        setAdmin.Text = "设为管理员";
        setAdmin.UseVisualStyleBackColor = true;
        setAdmin.Click += setAdmin_Click;
        // 
        // delUser
        // 
        delUser.Location = new Point(250, 918);
        delUser.Name = "delUser";
        delUser.Size = new Size(206, 64);
        delUser.TabIndex = 1;
        delUser.Text = "删除用户";
        delUser.UseVisualStyleBackColor = true;
        delUser.Click += delUser_Click;
        // 
        // newUser
        // 
        newUser.Location = new Point(19, 918);
        newUser.Name = "newUser";
        newUser.Size = new Size(206, 64);
        newUser.TabIndex = 1;
        newUser.Text = "新增用户";
        newUser.UseVisualStyleBackColor = true;
        newUser.Click += newUser_Click;
        // 
        // changePassword
        // 
        changePassword.Location = new Point(709, 918);
        changePassword.Name = "changePassword";
        changePassword.Size = new Size(206, 64);
        changePassword.TabIndex = 1;
        changePassword.Text = "修改密码";
        changePassword.UseVisualStyleBackColor = true;
        changePassword.Click += changePassword_Click;
        // 
        // changeUsername
        // 
        changeUsername.Location = new Point(478, 918);
        changeUsername.Name = "changeUsername";
        changeUsername.Size = new Size(206, 64);
        changeUsername.TabIndex = 1;
        changeUsername.Text = "修改用户名";
        changeUsername.UseVisualStyleBackColor = true;
        changeUsername.Click += changeUsername_Click;
        // 
        // userDataBox
        // 
        userDataBox.AllowUserToAddRows = false;
        userDataBox.AllowUserToDeleteRows = false;
        userDataBox.AllowUserToResizeColumns = false;
        userDataBox.AllowUserToResizeRows = false;
        userDataBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        userDataBox.BackgroundColor = SystemColors.Window;
        userDataBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        userDataBox.Location = new Point(0, 0);
        userDataBox.MultiSelect = false;
        userDataBox.Name = "userDataBox";
        userDataBox.ReadOnly = true;
        userDataBox.RowHeadersWidth = 82;
        userDataBox.SelectionMode = DataGridViewSelectionMode.CellSelect;
        userDataBox.Size = new Size(1692, 909);
        userDataBox.TabIndex = 0;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(cancelSeat);
        tabPage2.Controls.Add(button1);
        tabPage2.Controls.Add(button2);
        tabPage2.Controls.Add(roomNum);
        tabPage2.Controls.Add(seatNum);
        tabPage2.Controls.Add(isFree);
        tabPage2.Controls.Add(label5);
        tabPage2.Controls.Add(label6);
        tabPage2.Controls.Add(label7);
        tabPage2.Controls.Add(exportSeats);
        tabPage2.Controls.Add(importSeat);
        tabPage2.Controls.Add(removeSeat);
        tabPage2.Controls.Add(addSeat);
        tabPage2.Controls.Add(seatDataBox);
        tabPage2.Location = new Point(8, 45);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(1692, 982);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "座位管理";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // cancelSeat
        // 
        cancelSeat.Location = new Point(1166, 912);
        cancelSeat.Name = "cancelSeat";
        cancelSeat.Size = new Size(206, 64);
        cancelSeat.TabIndex = 19;
        cancelSeat.Text = "解除占用";
        cancelSeat.UseVisualStyleBackColor = true;
        cancelSeat.Click += cancelSeat_Click;
        // 
        // button1
        // 
        button1.Location = new Point(1532, 9);
        button1.Name = "button1";
        button1.Size = new Size(150, 46);
        button1.TabIndex = 17;
        button1.Text = "清除筛选";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(1364, 9);
        button2.Name = "button2";
        button2.Size = new Size(150, 46);
        button2.TabIndex = 18;
        button2.Text = "筛选";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // roomNum
        // 
        roomNum.FormattingEnabled = true;
        roomNum.Location = new Point(111, 14);
        roomNum.Name = "roomNum";
        roomNum.Size = new Size(307, 39);
        roomNum.TabIndex = 16;
        // 
        // seatNum
        // 
        seatNum.FormattingEnabled = true;
        seatNum.Location = new Point(553, 14);
        seatNum.Name = "seatNum";
        seatNum.Size = new Size(321, 39);
        seatNum.TabIndex = 15;
        // 
        // isFree
        // 
        isFree.FormattingEnabled = true;
        isFree.Location = new Point(1038, 14);
        isFree.Name = "isFree";
        isFree.Size = new Size(301, 39);
        isFree.TabIndex = 14;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(455, 14);
        label5.Name = "label5";
        label5.Size = new Size(92, 31);
        label5.TabIndex = 11;
        label5.Text = "座位号:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(916, 14);
        label6.Name = "label6";
        label6.Size = new Size(116, 31);
        label6.TabIndex = 12;
        label6.Text = "是否空闲:";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(13, 14);
        label7.Name = "label7";
        label7.Size = new Size(92, 31);
        label7.TabIndex = 13;
        label7.Text = "房间号:";
        // 
        // exportSeats
        // 
        exportSeats.Location = new Point(943, 912);
        exportSeats.Name = "exportSeats";
        exportSeats.Size = new Size(206, 64);
        exportSeats.TabIndex = 2;
        exportSeats.Text = "导出座位";
        exportSeats.UseVisualStyleBackColor = true;
        exportSeats.Click += exportSeats_Click;
        // 
        // importSeat
        // 
        importSeat.Location = new Point(721, 912);
        importSeat.Name = "importSeat";
        importSeat.Size = new Size(206, 64);
        importSeat.TabIndex = 2;
        importSeat.Text = "导入座位";
        importSeat.UseVisualStyleBackColor = true;
        importSeat.Click += importSeat_Click;
        // 
        // removeSeat
        // 
        removeSeat.Location = new Point(490, 912);
        removeSeat.Name = "removeSeat";
        removeSeat.Size = new Size(206, 64);
        removeSeat.TabIndex = 2;
        removeSeat.Text = "删除座位";
        removeSeat.UseVisualStyleBackColor = true;
        removeSeat.Click += removeSeat_Click;
        // 
        // addSeat
        // 
        addSeat.Location = new Point(264, 912);
        addSeat.Name = "addSeat";
        addSeat.Size = new Size(206, 64);
        addSeat.TabIndex = 2;
        addSeat.Text = "新增座位";
        addSeat.UseVisualStyleBackColor = true;
        addSeat.Click += addSeat_Click;
        // 
        // seatDataBox
        // 
        seatDataBox.AllowUserToAddRows = false;
        seatDataBox.AllowUserToDeleteRows = false;
        seatDataBox.AllowUserToResizeColumns = false;
        seatDataBox.AllowUserToResizeRows = false;
        seatDataBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        seatDataBox.BackgroundColor = SystemColors.Window;
        seatDataBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        seatDataBox.Location = new Point(-5, 71);
        seatDataBox.MultiSelect = false;
        seatDataBox.Name = "seatDataBox";
        seatDataBox.ReadOnly = true;
        seatDataBox.RowHeadersWidth = 82;
        seatDataBox.SelectionMode = DataGridViewSelectionMode.CellSelect;
        seatDataBox.Size = new Size(1692, 838);
        seatDataBox.TabIndex = 0;
        // 
        // tabPage3
        // 
        tabPage3.Controls.Add(label10);
        tabPage3.Controls.Add(exportAsExcel);
        tabPage3.Controls.Add(exportAsJson);
        tabPage3.Controls.Add(label9);
        tabPage3.Controls.Add(checkBox1);
        tabPage3.Controls.Add(removeButton);
        tabPage3.Controls.Add(button);
        tabPage3.Controls.Add(dateTimeEnd);
        tabPage3.Controls.Add(dateTimeStart);
        tabPage3.Controls.Add(userRes);
        tabPage3.Controls.Add(label8);
        tabPage3.Controls.Add(label4);
        tabPage3.Controls.Add(label2);
        tabPage3.Controls.Add(seatRes);
        tabPage3.Controls.Add(label3);
        tabPage3.Controls.Add(roomRes);
        tabPage3.Controls.Add(label1);
        tabPage3.Controls.Add(clearSat);
        tabPage3.Controls.Add(removeSat);
        tabPage3.Controls.Add(resDataBox);
        tabPage3.Location = new Point(8, 45);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(3);
        tabPage3.Size = new Size(1692, 982);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "预约记录管理";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(1151, 8);
        label10.Name = "label10";
        label10.Size = new Size(20, 93);
        label10.TabIndex = 23;
        label10.Text = "|\n|\n|";
        // 
        // exportAsExcel
        // 
        exportAsExcel.Location = new Point(1386, 51);
        exportAsExcel.Name = "exportAsExcel";
        exportAsExcel.Size = new Size(150, 46);
        exportAsExcel.TabIndex = 22;
        exportAsExcel.Text = "表格文件";
        exportAsExcel.UseVisualStyleBackColor = true;
        exportAsExcel.Click += exportAsExcel_Click;
        // 
        // exportAsJson
        // 
        exportAsJson.Location = new Point(1230, 51);
        exportAsJson.Name = "exportAsJson";
        exportAsJson.Size = new Size(150, 46);
        exportAsJson.TabIndex = 21;
        exportAsJson.Text = "Json文件";
        exportAsJson.UseVisualStyleBackColor = true;
        exportAsJson.Click += exportAsJson_Click;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(1230, 7);
        label9.Name = "label9";
        label9.Size = new Size(206, 31);
        label9.TabIndex = 20;
        label9.Text = "将筛选结果导出为";
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(19, 66);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(190, 35);
        checkBox1.TabIndex = 19;
        checkBox1.Text = "启用时间搜索";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // removeButton
        // 
        removeButton.Location = new Point(978, 59);
        removeButton.Name = "removeButton";
        removeButton.Size = new Size(127, 46);
        removeButton.TabIndex = 17;
        removeButton.Text = "清除筛选";
        removeButton.UseVisualStyleBackColor = true;
        removeButton.Click += removeButton_Click;
        // 
        // button
        // 
        button.Location = new Point(978, 7);
        button.Name = "button";
        button.Size = new Size(127, 46);
        button.TabIndex = 18;
        button.Text = "筛选";
        button.UseVisualStyleBackColor = true;
        button.Click += button_Click;
        // 
        // dateTimeEnd
        // 
        dateTimeEnd.Location = new Point(720, 66);
        dateTimeEnd.Name = "dateTimeEnd";
        dateTimeEnd.Size = new Size(232, 38);
        dateTimeEnd.TabIndex = 16;
        // 
        // dateTimeStart
        // 
        dateTimeStart.Location = new Point(357, 66);
        dateTimeStart.Name = "dateTimeStart";
        dateTimeStart.Size = new Size(232, 38);
        dateTimeStart.TabIndex = 16;
        // 
        // userRes
        // 
        userRes.FormattingEnabled = true;
        userRes.Location = new Point(737, 14);
        userRes.Name = "userRes";
        userRes.Size = new Size(215, 39);
        userRes.TabIndex = 15;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(598, 66);
        label8.Name = "label8";
        label8.Size = new Size(116, 31);
        label8.TabIndex = 14;
        label8.Text = "结束时间:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(639, 14);
        label4.Name = "label4";
        label4.Size = new Size(92, 31);
        label4.TabIndex = 14;
        label4.Text = "预约者:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(235, 66);
        label2.Name = "label2";
        label2.Size = new Size(116, 31);
        label2.TabIndex = 14;
        label2.Text = "起始时间:";
        // 
        // seatRes
        // 
        seatRes.FormattingEnabled = true;
        seatRes.Location = new Point(423, 14);
        seatRes.Name = "seatRes";
        seatRes.Size = new Size(210, 39);
        seatRes.TabIndex = 13;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(325, 14);
        label3.Name = "label3";
        label3.Size = new Size(92, 31);
        label3.TabIndex = 12;
        label3.Text = "座位号:";
        // 
        // roomRes
        // 
        roomRes.FormattingEnabled = true;
        roomRes.Location = new Point(116, 14);
        roomRes.Name = "roomRes";
        roomRes.Size = new Size(203, 39);
        roomRes.TabIndex = 11;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(18, 14);
        label1.Name = "label1";
        label1.Size = new Size(92, 31);
        label1.TabIndex = 10;
        label1.Text = "房间号:";
        // 
        // clearSat
        // 
        clearSat.Location = new Point(899, 912);
        clearSat.Name = "clearSat";
        clearSat.Size = new Size(206, 64);
        clearSat.TabIndex = 3;
        clearSat.Text = "清空记录";
        clearSat.UseVisualStyleBackColor = true;
        clearSat.Click += clearSat_Click;
        // 
        // removeSat
        // 
        removeSat.Location = new Point(668, 912);
        removeSat.Name = "removeSat";
        removeSat.Size = new Size(206, 64);
        removeSat.TabIndex = 3;
        removeSat.Text = "删除记录";
        removeSat.UseVisualStyleBackColor = true;
        removeSat.Click += removeSat_Click;
        // 
        // resDataBox
        // 
        resDataBox.AllowUserToAddRows = false;
        resDataBox.AllowUserToDeleteRows = false;
        resDataBox.AllowUserToResizeColumns = false;
        resDataBox.AllowUserToResizeRows = false;
        resDataBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        resDataBox.BackgroundColor = SystemColors.Window;
        resDataBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        resDataBox.Location = new Point(0, 110);
        resDataBox.MultiSelect = false;
        resDataBox.Name = "resDataBox";
        resDataBox.ReadOnly = true;
        resDataBox.RowHeadersWidth = 82;
        resDataBox.SelectionMode = DataGridViewSelectionMode.CellSelect;
        resDataBox.Size = new Size(1692, 799);
        resDataBox.TabIndex = 1;
        // 
        // info
        // 
        info.AutoSize = true;
        info.Font = new Font("Microsoft YaHei UI", 13.875F);
        info.Location = new Point(12, 9);
        info.Name = "info";
        info.Size = new Size(267, 48);
        info.TabIndex = 1;
        info.Text = "你好，{admin}";
        // 
        // refresh
        // 
        refresh.Location = new Point(1334, 15);
        refresh.Name = "refresh";
        refresh.Size = new Size(172, 72);
        refresh.TabIndex = 2;
        refresh.Text = "刷新";
        refresh.UseVisualStyleBackColor = true;
        refresh.Click += refresh_Click;
        // 
        // exitButton
        // 
        exitButton.Location = new Point(1521, 15);
        exitButton.Name = "exitButton";
        exitButton.Size = new Size(172, 72);
        exitButton.TabIndex = 2;
        exitButton.Text = "退出系统";
        exitButton.UseVisualStyleBackColor = true;
        exitButton.Click += exitButton_Click;
        // 
        // Admin
        // 
        AutoScaleDimensions = new SizeF(14F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1705, 1142);
        Controls.Add(exitButton);
        Controls.Add(refresh);
        Controls.Add(info);
        Controls.Add(seatData);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "Admin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "湘潭大学图书馆预约系统 管理端";
        Load += Admin_Load;
        seatData.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        ((ISupportInitialize)userDataBox).EndInit();
        tabPage2.ResumeLayout(false);
        tabPage2.PerformLayout();
        ((ISupportInitialize)seatDataBox).EndInit();
        tabPage3.ResumeLayout(false);
        tabPage3.PerformLayout();
        ((ISupportInitialize)resDataBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TabControl seatData;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Label info;
    private DataGridView userDataBox;
    private Button changeUsername;
    private Button changePassword;
    private Button setAdmin;
    private Button delUser;
    private Button newUser;
    private Button setUser;
    private Button clearSeats;
    private TabPage tabPage3;
    private DataGridView seatDataBox;
    private Button exportSeats;
    private Button importSeat;
    private Button removeSeat;
    private Button addSeat;
    private DataGridView resDataBox;
    private Button clearSat;
    private Button removeSat;
    private ComboBox roomRes;
    private Label label1;
    private ComboBox seatRes;
    private Label label3;
    private DateTimePicker dateTimeStart;
    private ComboBox userRes;
    private Label label4;
    private Label label2;
    private Button removeButton;
    private Button button;
    private Button button1;
    private Button button2;
    private ComboBox roomNum;
    private ComboBox seatNum;
    private ComboBox isFree;
    private Label label5;
    private Label label6;
    private Label label7;
    private Button cancelSeat;
    private CheckBox checkBox1;
    private Button refresh;
    private DateTimePicker dateTimeEnd;
    private Label label8;
    private Label label9;
    private Button exportAsExcel;
    private Button exportAsJson;
    private Label label10;
    private Button exitButton;
}