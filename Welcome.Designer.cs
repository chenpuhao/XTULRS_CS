using System.ComponentModel;

namespace LRS;

partial class Welcome
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Welcome));
        label = new Label();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        SuspendLayout();
        // 
        // label
        // 
        label.Cursor = Cursors.No;
        label.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label.Location = new Point(1, -7);
        label.Name = "label";
        label.Size = new Size(205, 84);
        label.TabIndex = 0;
        label.Text = "欢迎登录";
        label.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label1.Location = new Point(30, 89);
        label1.Name = "label1";
        label1.Size = new Size(724, 124);
        label1.TabIndex = 1;
        label1.Text = "湘潭大学图书馆";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Microsoft YaHei UI", 36F);
        label2.Location = new Point(164, 213);
        label2.Name = "label2";
        label2.Size = new Size(436, 124);
        label2.TabIndex = 2;
        label2.Text = "预约系统";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(566, 410);
        label3.Name = "label3";
        label3.Size = new Size(222, 31);
        label3.TabIndex = 3;
        label3.Text = "作者： chenpuhao";
        // 
        // Welcome
        // 
        AutoScaleDimensions = new SizeF(14F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(label);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        Name = "Welcome";
        RightToLeft = RightToLeft.No;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "湘潭大学图书馆预约系统";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label;

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
}