using System.Media;

namespace WinFormsApp2
{
    public partial class Minesweeper : Form
    {
        const int Rows = 5;
        const int Columns = 5;
        const int MineCount = 5;
        
        private bool[,] mines;
        private bool[,] revealed;
        private bool[,] flagged;
        private Label[,] labels;
        private SoundPlayer player_Sector;
        private SoundPlayer player_Evrey;
        private SoundPlayer player_Bam;

        public Minesweeper()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            
            player_Sector = new SoundPlayer(@"C:\Users\User\OneDrive\Desktop\основы программированния\laba6\WinFormsApp2\Sektor_Gaza_-_Sektor_GazaSHinnyjj_TJEC_VoGRJES_SKSektor_gaza_-_zdes_ne_dozhit_do_sorokaSektor_Gaza_- (mp3cut.net).wav");
            player_Evrey = new SoundPlayer(@"C:\Users\User\OneDrive\Desktop\основы программированния\laba6\WinFormsApp2\еврей.wav");
            player_Bam = new SoundPlayer(@"C:\Users\User\OneDrive\Desktop\основы программированния\laba6\WinFormsApp2\бам.wav");
            
            InitializeLabelsArray();
            StartGame();
        }
        
        
        private void InitializeLabelsArray()
        {
            labels = new Label[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    int labelNumber = i * Columns + j + 1;
                    string labelName = $"Click{labelNumber}";
                    
                    Label lbl = this.Controls.Find(labelName, true).FirstOrDefault() as Label;
            
                    if (lbl != null)
                    {
                        labels[i, j] = lbl;
                        lbl.MouseDown += new MouseEventHandler(MineFieldElement_MouseDown);
                        lbl.Cursor = Cursors.Hand; 
                        lbl.Tag = new Point(i, j); 
                    }
                }
            }
        }
        
        private void StartGame()
        {
            player_Sector.Play();
            mines = new bool[Rows, Columns];
            revealed = new bool[Rows, Columns];
            flagged = new bool[Rows, Columns];
            
            Random rnd = new Random();
            int placed = 0;
            while (placed < MineCount)
            {
                int r = rnd.Next(Rows); 
                int c = rnd.Next(Columns);
                if (!mines[r, c])
                {
                    mines[r, c] = true;
                    placed++;
                }
            }
            
            foreach (Label btn in labels)
            {
                if (btn != null)
                {
                    btn.Text = "";
                    btn.Enabled = true;
                }
            }
        }
        
        private void DisableAllElements()
        {
            foreach (Label lbl in labels)
            {
                if (lbl != null)
                {
                    lbl.MouseDown -= MineFieldElement_MouseDown;
                    lbl.Cursor = Cursors.Default;
                }
            }
        }
        
        private void MineFieldElement_MouseDown(object sender, MouseEventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel == null) return; 

            Point coords = (Point)clickedLabel.Tag;
            int r = coords.X;
            int c = coords.Y;
            
            if (revealed[r, c] && e.Button == MouseButtons.Left) return; 
    
            if (e.Button == MouseButtons.Right)
            {
                if (!revealed[r, c])
                {
                    flagged[r, c] = !flagged[r, c];
                    clickedLabel.Text = flagged[r, c] ? "🚩" : "";
                    CheckWin();
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (flagged[r, c]) return;

                if (mines[r, c])
                {
                    player_Sector.Stop();
                    player_Bam.Play();
                    clickedLabel.BackColor = System.Drawing.Color.Red;
                    ShowAllMines();
                    MessageBox.Show("Взрыв! Вы проиграли!", "Игра окончена", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DisableAllElements();
                    player_Bam.Stop();
                }
                else
                {
                    RevealEmpty(r, c);
                    CheckWin();
                }
            }
        }


        private int CountMines(int r, int c)
        {
            int count = 0;
            for (int k = -1; k <= 1; k++)
                for (int l = -1; l <= 1; l++)
                {
                    if (k == 0 && l == 0) continue;
                    int neighborR = k + r, neighborC = l + c;
                    

                    if (neighborR >= 0 && neighborR < Rows && neighborC >= 0 && neighborC < Columns)
                    {
                        if (mines[neighborR, neighborC])
                            count++;
                    }
                }
            return count;
        }
        
        private void RevealEmpty(int r, int c)
        {
            if (r < 0 || r >= Rows || c < 0 || c >= Columns || revealed[r, c] || mines[r, c]) return;

            revealed[r, c] = true;
            flagged[r, c] = false;
            
            UpdateButtonAppearance(r, c);

            if (CountMines(r, c) == 0)
            {
                for (int i = -1; i <= 1; i++)
                    for (int j = -1; j <= 1; j++)
                        if (i != 0 || j != 0)
                            RevealEmpty(r + i, c + j);
            }
        }
        
        private void UpdateButtonAppearance(int r, int c)
        {
            Label btn = labels[r, c];
            
            if (revealed[r, c])
            {
                int count = CountMines(r, c);

                btn.Text = count == 0 ? "" : count.ToString();
                btn.BackColor = System.Drawing.Color.WhiteSmoke;
                btn.Font = new System.Drawing.Font(btn.Font.FontFamily, 10, System.Drawing.FontStyle.Bold);

                if (count == 1)
                {
                    btn.ForeColor = System.Drawing.Color.Blue;
                }
                else if (count == 2)
                {
                    btn.ForeColor = System.Drawing.Color.Green;
                }
                else if (count == 3)
                {
                    btn.ForeColor = System.Drawing.Color.Red;
                }
                else if (count == 4)
                {
                    btn.ForeColor = System.Drawing.Color.DarkBlue;
                }
                else
                {
                    btn.ForeColor = System.Drawing.Color.DarkRed;
                }
            }
        }
        
        private void CheckWin()
        {
            int openCells = 0;
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    if (revealed[i, j] && !mines[i, j])
                        openCells++;
            
            if (openCells == Rows * Columns - MineCount)
            {
                player_Sector.Stop();
                player_Evrey.Play();
                MessageBox.Show("Вы победили, мойша довелен!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableAllButtons();
                player_Evrey.Stop();
            }
        }

        private void ShowAllMines()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (mines[i, j])
                    {
                        labels[i, j].Text = "💣";
                        labels[i, j].BackColor = System.Drawing.Color.OrangeRed;
                    }
                }
            }
        }

        private void DisableAllButtons()
        {
            foreach (Label btn in labels)
            {
                if (btn != null) btn.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            player_Sector.Stop();
        }
    }
}