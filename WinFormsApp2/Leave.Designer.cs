using System.ComponentModel;

namespace WinFormsApp2;

partial class Leave
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leave));
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.DarkGreen;
        button1.Location = new System.Drawing.Point(153, 97);
        button1.Margin = new System.Windows.Forms.Padding(55, 2, 55, 2);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(150, 113);
        button1.TabIndex = 0;
        button1.Text = "Да";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.Red;
        button2.Location = new System.Drawing.Point(413, 97);
        button2.Margin = new System.Windows.Forms.Padding(55, 2, 55, 2);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(134, 113);
        button2.TabIndex = 1;
        button2.Text = "Нет";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Cursor = System.Windows.Forms.Cursors.Default;
        label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(153, 29);
        label1.Margin = new System.Windows.Forms.Padding(55, 0, 55, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(394, 41);
        label1.TabIndex = 2;
        label1.Text = "Вы точно хотите выйти?";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        label1.UseMnemonic = false;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(0, 0);
        pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(716, 434);
        pictureBox1.TabIndex = 3;
        pictureBox1.TabStop = false;
        // 
        // Leave
        // 
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        ClientSize = new System.Drawing.Size(715, 431);
        Controls.Add(label1);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(pictureBox1);
        Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Выход (есть)";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    #endregion
}