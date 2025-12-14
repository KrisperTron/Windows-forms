namespace WinFormsApp2;

partial class Menu
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        button5 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(240, 12);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(297, 62);
        button1.TabIndex = 0;
        button1.Text = "Отгадайка";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(238, 264);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(300, 65);
        button2.TabIndex = 1;
        button2.Text = "Об авторе";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(238, 97);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(299, 68);
        button3.TabIndex = 2;
        button3.Text = "Сортировка массива";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(237, 182);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(298, 62);
        button4.TabIndex = 3;
        button4.Text = "Сапёр";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button5
        // 
        button5.Location = new System.Drawing.Point(238, 367);
        button5.Name = "button5";
        button5.Size = new System.Drawing.Size(297, 62);
        button5.TabIndex = 4;
        button5.Text = "Выход";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // Menu
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Text = "Laba 6";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button5;

    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    #endregion
}