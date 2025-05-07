using System.ComponentModel;

namespace LRS;

partial class addSeatForm
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(addSeatForm));
        roomBox = new TextBox();
        username = new Label();
        label1 = new Label();
        seatBox = new TextBox();
        confirm = new Button();
        SuspendLayout();
        // 
        // roomBox
        // 
        roomBox.Location = new Point(170, 61);
        roomBox.Name = "roomBox";
        roomBox.Size = new Size(442, 38);
        roomBox.TabIndex = 3;
        // 
        // username
        // 
        username.AutoSize = true;
        username.Location = new Point(54, 64);
        username.Name = "username";
        username.Size = new Size(110, 31);
        username.TabIndex = 2;
        username.Text = "房间号：";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(54, 125);
        label1.Name = "label1";
        label1.Size = new Size(110, 31);
        label1.TabIndex = 2;
        label1.Text = "座位号：";
        // 
        // seatBox
        // 
        seatBox.Location = new Point(170, 122);
        seatBox.Name = "seatBox";
        seatBox.Size = new Size(442, 38);
        seatBox.TabIndex = 3;
        // 
        // confirm
        // 
        confirm.Location = new Point(261, 199);
        confirm.Name = "confirm";
        confirm.Size = new Size(150, 46);
        confirm.TabIndex = 4;
        confirm.Text = "确定";
        confirm.UseVisualStyleBackColor = true;
        confirm.Click += confirm_Click;
        // 
        // addSeatForm
        // 
        AutoScaleDimensions = new SizeF(14F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(687, 279);
        Controls.Add(confirm);
        Controls.Add(seatBox);
        Controls.Add(label1);
        Controls.Add(roomBox);
        Controls.Add(username);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        Name = "addSeatForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "湘潭大学图书馆预约系统 添加座位";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox roomBox;
    private Label username;
    private Label label1;
    private TextBox seatBox;
    private Button confirm;
}