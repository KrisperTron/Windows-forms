using System.Media;
using System.Threading.Tasks;

namespace WinFormsApp2;

public partial class RandomNum : Form
{
    private SoundPlayer player_Win;
    private SoundPlayer player_TimeEnd;
    private SoundPlayer player_Time;
    private SoundPlayer player_NoNum;
    private SoundPlayer player_NoCount;
    
    public int attempts = 0;
    public double result;
    public int userNum;
    public int numCount;
    public double num;
    public int timeLeft = 30;
    
    
    public RandomNum()
    {
        InitializeComponent(); 
        this.StartPosition = FormStartPosition.CenterScreen;
        this.MaximizeBox = false;
        
        player_Win = new SoundPlayer(@"C:\Users\User\OneDrive\Desktop\основы программированния\laba6\WinFormsApp2\победа.wav");
        player_NoNum = new SoundPlayer(@"C:\Users\User\OneDrive\Desktop\основы программированния\laba6\WinFormsApp2\Неправильно.wav");
        player_TimeEnd = new SoundPlayer(@"C:\Users\User\OneDrive\Desktop\основы программированния\laba6\WinFormsApp2\Время вышло.wav");
        player_Time = new SoundPlayer(@"C:\Users\User\OneDrive\Desktop\основы программированния\laba6\WinFormsApp2\часы.wav");
        player_NoCount = new SoundPlayer(@"C:\Users\User\OneDrive\Desktop\основы программированния\laba6\WinFormsApp2\Попытки.wav");
        
        
        label3.Visible = false;
        label4.Visible = false;
        label5.Visible = false;
        textBox3.Visible = false;
        button2.Visible = false;
        pictureBox2.Visible = false;
        button1.Visible = true;
        label7.Visible = false;
        label9.Visible = false;
    }
    
    private void RandomNum_FormClosing(object sender, FormClosingEventArgs e)
    {
        player_Time.Stop();
    }

    private void textBox1_TextChanged_1(object sender, EventArgs e)
    {
        if (!double.TryParse(textBox1.Text, out _))
        {
            label3.Visible = true;
        }
        
        else
        {
            label3.Visible = false;
        }
        
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (label4.Visible == false && label3.Visible == false && textBox1.Text != "" && textBox2.Text != "")
        {
            userNum = InputValue.CheckInt(textBox1.Text);
            result = ResultNum.Task(userNum);
            button1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            pictureBox1.Visible = false;
            textBox3.Visible = true;
            button2.Visible = true;
            pictureBox2.Visible = true;
            label7.Visible = true;
            button2.Enabled = false;
            label9.Visible = false;
            label7.Text = $"Попытки: {attempts}/{numCount}";
            timeLeft = 30; // или любое число
            label8.Visible = true;
            label8.Text = $"Время: {timeLeft}";
            timer1.Start();
            progressBar1.Visible = true;
            progressBar1.Maximum = timeLeft;
            progressBar1.Value = timeLeft;
            player_Time.Play();
        }
        else
        {
            label9.Visible = true;
        }
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        if (!int.TryParse(textBox2.Text, out int a) || a <= 0)
        {
            label4.Visible = true;
        }

        else
        {
            numCount = int.Parse(textBox2.Text);
            label4.Visible = false;
        }
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
        if (!double.TryParse(textBox3.Text, out double value))
        {
            label5.Visible = true;
            button2.Enabled = false;
        }
        else
        {
            num = value;
            label5.Visible = false;
            button2.Enabled = true;
        }
    }


    private void button2_Click(object sender, EventArgs e)
    {
        attempts++;
        label7.Text = $"Попытки: {attempts}/{numCount}";

        if (!double.TryParse(textBox3.Text, out double userValue))
            return;

        // Если угадал правильно
        if (userValue == result)
        {
            player_Time.Stop();
            player_Win.Play();
            timer1.Stop();
            button2.Enabled = false;
            MessageBox.Show("ТЫ ОТГАДАЛ!");
            return;
        }
        
        player_Time.Stop();
        player_NoNum.Play();
        
        Task.Run(async () =>
        {
            await Task.Delay(4300); 

            this.Invoke(new Action(() =>
            {
                if (timer1.Enabled && timeLeft > 0)
                {
                    player_Time.Play();
                }
            }));
        });
        
        if (attempts >= numCount)
        {
            label7.Text += " — Конец попыток.";
            button2.Enabled = false;
            timer1.Stop();
            player_Time.Stop(); // Останавливаем часы, если попытки закончились
            player_NoCount.Play();
        }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        
        timeLeft--;

        label8.Text = $"Время: {timeLeft}";
        if (progressBar1.Value > 0)
            progressBar1.Value = timeLeft;
        
        if (timeLeft <= 0)
        {
            player_TimeEnd.Play();
            progressBar1.Value = 0;
            timer1.Stop();
            button2.Enabled = false;
            MessageBox.Show("Время вышло!");
            label8.Text = "Время: 0";
        }
    }

    private void button3_Click_1(object sender, EventArgs e)
    {
        player_Win.Stop();
        player_NoNum.Stop();
        player_Time.Stop();
        player_NoCount.Stop();
        this.Close();
    }
}