using System.ComponentModel;

namespace WinFormsApp2;

partial class SortArr
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortArr));
        Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        button1 = new System.Windows.Forms.Button();
        textBox1 = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        button5 = new System.Windows.Forms.Button();
        button6 = new System.Windows.Forms.Button();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        button7 = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // Column1
        // 
        Column1.HeaderText = "Column1";
        Column1.MinimumWidth = 6;
        Column1.Name = "Column1";
        Column1.Width = 125;
        // 
        // Column2
        // 
        Column2.HeaderText = "Column2";
        Column2.MinimumWidth = 6;
        Column2.Name = "Column2";
        Column2.Width = 159;
        // 
        // Column3
        // 
        Column3.HeaderText = "Column3";
        Column3.MinimumWidth = 6;
        Column3.Name = "Column3";
        Column3.Width = 125;
        // 
        // Column4
        // 
        Column4.HeaderText = "Column4";
        Column4.MinimumWidth = 6;
        Column4.Name = "Column4";
        Column4.Width = 125;
        // 
        // Column5
        // 
        Column5.HeaderText = "Column5";
        Column5.MinimumWidth = 6;
        Column5.Name = "Column5";
        Column5.Width = 125;
        // 
        // Column6
        // 
        Column6.HeaderText = "Column6";
        Column6.MinimumWidth = 6;
        Column6.Name = "Column6";
        Column6.Width = 125;
        // 
        // Column7
        // 
        Column7.HeaderText = "Column7";
        Column7.MinimumWidth = 6;
        Column7.Name = "Column7";
        Column7.Width = 125;
        // 
        // Column8
        // 
        Column8.HeaderText = "Column8";
        Column8.MinimumWidth = 6;
        Column8.Name = "Column8";
        Column8.Width = 125;
        // 
        // Column9
        // 
        Column9.HeaderText = "Column9";
        Column9.MinimumWidth = 6;
        Column9.Name = "Column9";
        Column9.Width = 125;
        // 
        // Column10
        // 
        Column10.HeaderText = "Column10";
        Column10.MinimumWidth = 6;
        Column10.Name = "Column10";
        Column10.Width = 125;
        // 
        // Column11
        // 
        Column11.HeaderText = "Column11";
        Column11.MinimumWidth = 6;
        Column11.Name = "Column11";
        Column11.Width = 125;
        // 
        // Column12
        // 
        Column12.HeaderText = "Column12";
        Column12.MinimumWidth = 6;
        Column12.Name = "Column12";
        Column12.Width = 125;
        // 
        // button1
        // 
        button1.Font = new System.Drawing.Font("Rubik", 11F);
        button1.Location = new System.Drawing.Point(238, 223);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(300, 62);
        button1.TabIndex = 0;
        button1.Text = "Длина по умолчанию";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(238, 122);
        textBox1.Name = "textBox1";
        textBox1.PlaceholderText = "Введите размер массива";
        textBox1.Size = new System.Drawing.Size(302, 27);
        textBox1.TabIndex = 1;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // label2
        // 
        label2.ForeColor = System.Drawing.Color.IndianRed;
        label2.Location = new System.Drawing.Point(236, 168);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(302, 25);
        label2.TabIndex = 3;
        label2.Text = "Неверный ввод";
        // 
        // button2
        // 
        button2.Font = new System.Drawing.Font("Rubik", 11F);
        button2.Location = new System.Drawing.Point(236, 331);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(302, 50);
        button2.TabIndex = 4;
        button2.Text = "Далее";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click_1;
        // 
        // button3
        // 
        button3.Font = new System.Drawing.Font("Rubik", 11F);
        button3.Location = new System.Drawing.Point(12, 93);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(341, 72);
        button3.TabIndex = 5;
        button3.Text = "Случайный массив";
        button3.UseVisualStyleBackColor = true;
        button3.Visible = false;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Font = new System.Drawing.Font("Rubik", 11F);
        button4.Location = new System.Drawing.Point(488, 74);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(303, 54);
        button4.TabIndex = 6;
        button4.Text = "Сортировка массива";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button5
        // 
        button5.Font = new System.Drawing.Font("Rubik", 9F);
        button5.Location = new System.Drawing.Point(488, 134);
        button5.Name = "button5";
        button5.Size = new System.Drawing.Size(299, 58);
        button5.TabIndex = 7;
        button5.Text = "Максимальный и минимальный массив";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // button6
        // 
        button6.Font = new System.Drawing.Font("Rubik", 9F);
        button6.Location = new System.Drawing.Point(488, 198);
        button6.Name = "button6";
        button6.Size = new System.Drawing.Size(299, 56);
        button6.TabIndex = 8;
        button6.Text = "Среднее арифметическое массива\r\n";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new System.Drawing.Point(12, 171);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new System.Drawing.Size(341, 218);
        dataGridView1.TabIndex = 9;
        dataGridView1.Text = "dataGridView1";
        // 
        // label3
        // 
        label3.BackColor = System.Drawing.Color.Transparent;
        label3.Location = new System.Drawing.Point(17, 8);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(335, 26);
        label3.TabIndex = 10;
        label3.Text = "label3";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(17, 53);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(339, 24);
        label4.TabIndex = 11;
        label4.Text = "label4";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(488, 288);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(299, 26);
        label5.TabIndex = 12;
        label5.Text = "label5";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(1, -3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(805, 454);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 13;
        pictureBox1.TabStop = false;
        // 
        // button7
        // 
        button7.Font = new System.Drawing.Font("Rubik", 11F);
        button7.Location = new System.Drawing.Point(561, 378);
        button7.Name = "button7";
        button7.Size = new System.Drawing.Size(217, 60);
        button7.TabIndex = 14;
        button7.Text = "В меню";
        button7.UseVisualStyleBackColor = true;
        button7.Click += button7_Click;
        // 
        // SortArr
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button7);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(dataGridView1);
        Controls.Add(button6);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(button1);
        Controls.Add(pictureBox1);
        Text = "Ящики ящики";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button7;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Button button6;

    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column12;

    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion
}