using System.Media;

namespace WinFormsApp2;

public partial class Leave : Form
{
    private SoundPlayer player_Exit;

    public Leave()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;
        this.ControlBox = false;
        
        player_Exit = new SoundPlayer(@"C:\Users\User\OneDrive\Desktop\основы программированния\laba6\WinFormsApp2\я устал.wav");
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        player_Exit.Stop();
        this.Close();
    }
}