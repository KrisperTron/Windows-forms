using System.ComponentModel;

namespace WinFormsApp2;

partial class RandomNum
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomNum));
        button1 = new System.Windows.Forms.Button();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        textBox3 = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        button2 = new System.Windows.Forms.Button();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        label7 = new System.Windows.Forms.Label();
        timer1 = new System.Windows.Forms.Timer(components);
        label8 = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        progressBar1 = new System.Windows.Forms.ProgressBar();
        button3 = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(333, 333);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(152, 58);
        button1.TabIndex = 0;
        button1.Text = "Ответить";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.ErrorImage = null;
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.InitialImage = null;
        pictureBox1.Location = new System.Drawing.Point(491, 106);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(242, 73);
        pictureBox1.TabIndex = 3;
        pictureBox1.TabStop = false;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(45, 76);
        textBox1.Name = "textBox1";
        textBox1.PlaceholderText = "Введите число";
        textBox1.Size = new System.Drawing.Size(216, 27);
        textBox1.TabIndex = 6;
        textBox1.TextChanged += textBox1_TextChanged_1;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(47, 152);
        textBox2.Name = "textBox2";
        textBox2.PlaceholderText = "Введите количество попыток";
        textBox2.Size = new System.Drawing.Size(224, 27);
        textBox2.TabIndex = 7;
        textBox2.TextChanged += textBox2_TextChanged;
        // 
        // label3
        // 
        label3.ForeColor = System.Drawing.Color.IndianRed;
        label3.Location = new System.Drawing.Point(45, 106);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(191, 18);
        label3.TabIndex = 8;
        label3.Text = "Неверный ввод";
        // 
        // label4
        // 
        label4.ForeColor = System.Drawing.Color.IndianRed;
        label4.Location = new System.Drawing.Point(60, 182);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(191, 18);
        label4.TabIndex = 9;
        label4.Text = "Неверный ввод";
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(47, 241);
        textBox3.Name = "textBox3";
        textBox3.PlaceholderText = "Напишите число";
        textBox3.Size = new System.Drawing.Size(266, 27);
        textBox3.TabIndex = 10;
        textBox3.TextChanged += textBox3_TextChanged;
        // 
        // label5
        // 
        label5.ForeColor = System.Drawing.Color.IndianRed;
        label5.Location = new System.Drawing.Point(47, 271);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(245, 21);
        label5.TabIndex = 11;
        label5.Text = "Неверный ввод";
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(333, 333);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(152, 58);
        button2.TabIndex = 13;
        button2.Text = "Ответить";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = ((System.Drawing.Image)resources.GetObject("pictureBox2.Image"));
        pictureBox2.Location = new System.Drawing.Point(192, 1);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(379, 224);
        pictureBox2.TabIndex = 14;
        pictureBox2.TabStop = false;
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(431, 241);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(359, 38);
        label7.TabIndex = 15;
        // 
        // timer1
        // 
        timer1.Interval = 1000;
        timer1.Tick += timer1_Tick;
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(60, 356);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(235, 35);
        label8.TabIndex = 16;
        label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label9
        // 
        label9.ForeColor = System.Drawing.Color.IndianRed;
        label9.Location = new System.Drawing.Point(350, 303);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(139, 27);
        label9.TabIndex = 17;
        label9.Text = "Введите верно";
        // 
        // progressBar1
        // 
        progressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
        progressBar1.Location = new System.Drawing.Point(47, 316);
        progressBar1.Maximum = 30;
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new System.Drawing.Size(273, 37);
        progressBar1.TabIndex = 18;
        progressBar1.Value = 30;
        progressBar1.Visible = false;
        // 
        // button3
        // 
        button3.Font = new System.Drawing.Font("Segoe UI", 11F);
        button3.Location = new System.Drawing.Point(666, 349);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(148, 49);
        button3.TabIndex = 19;
        button3.Text = "В меню";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click_1;
        // 
        // RandomNum
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoSize = true;
        AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        BackColor = System.Drawing.Color.LightGray;
        ClientSize = new System.Drawing.Size(826, 422);
        Controls.Add(button3);
        Controls.Add(progressBar1);
        Controls.Add(label9);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(pictureBox2);
        Controls.Add(button2);
        Controls.Add(label5);
        Controls.Add(textBox3);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(pictureBox1);
        Controls.Add(button1);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Location = new System.Drawing.Point(19, 19);
        Text = "Отгадайка";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.ProgressBar progressBar1;

    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.Timer timer1;

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.TextBox textBox3;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Button button1;

    #endregion
}