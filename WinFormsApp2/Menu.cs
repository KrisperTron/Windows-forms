using System.Media;

namespace WinFormsApp2;

public partial class Menu : Form
{
    private SoundPlayer player_RndNum;
    private SoundPlayer player_Author;
    private SoundPlayer player_Exit;
    
    
    public Menu()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;
        this.MaximizeBox = false;
        player_RndNum = new SoundPlayer(@"C:\Users\User\OneDrive\Desktop\основы программированния\laba6\WinFormsApp2\WinFormsApp2\Новый проект.wav");
        player_Author = new SoundPlayer(@"C:\Users\User\OneDrive\Desktop\основы программированния\laba6\WinFormsApp2\инженер.wav");
        player_Exit = new SoundPlayer(@"C:\Users\User\OneDrive\Desktop\основы программированния\laba6\WinFormsApp2\я устал.wav");
    }
    

    private void button2_Click(object sender, EventArgs e)
    {
        player_Author.Play();

        Form messageBox = new Form()
        {
            Width = 350,
            Height = 300,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            StartPosition = FormStartPosition.CenterScreen,
            Text = "👑Об авторе👑",
            BackColor = Color.White,
            MaximizeBox = false,
            MinimizeBox = false
        };

        PictureBox icon = new PictureBox()
        {
            Image = SystemIcons.Information.ToBitmap(),
            Location = new Point(15, 20),
            Size = new Size(40, 40)
        };
        
        Label title = new Label()
        {
            Text = "🤑Автор проекта🤑",
            Font = new Font("Arial", 14, FontStyle.Bold),
            Location = new Point(60, 20),
            AutoSize = true,
            ForeColor = Color.FromArgb(0, 102, 204)
        };
        
        Label info = new Label()
        {
            Text = "😎Name😎\n\n😍Group: 6101-090301D😍",
            Font = new Font("Arial", 11),
            Location = new Point(20, 70),
            Size = new Size(300, 100),
            TextAlign = ContentAlignment.MiddleCenter
        };
        
        Button okButton = new Button()
        {
            Text = "OK",
            Size = new Size(100, 30),
            Location = new Point(125, 180),
            DialogResult = DialogResult.OK,
            BackColor = Color.FromArgb(0, 102, 204),
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat
        };
    
        okButton.Click += (s, e) => { messageBox.Close(); };
    
        messageBox.Controls.Add(icon);
        messageBox.Controls.Add(title);
        messageBox.Controls.Add(info);
        messageBox.Controls.Add(okButton);
    
        messageBox.ShowDialog();
        player_Author.Stop();
    }


    private void button1_Click(object sender, EventArgs e)
    {
        RandomNum randomNum = new RandomNum();
        player_RndNum.Play();
        randomNum.FormClosed += (s, args) => this.Show();
        this.Hide();
        randomNum.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        SortArr array = new SortArr();
        array.FormClosed += (s, args) => this.Show();
        this.Hide();
        array.Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        Minesweeper mine = new Minesweeper();
        mine.FormClosed += (s, args) => this.Show();
        this.Hide();
        mine.Show();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        player_Exit.Play();
        Leave exit = new Leave();
        exit.FormClosed += (s, args) => this.Show();
        this.Hide();
        exit.Show();
    }
}