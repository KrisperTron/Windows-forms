using System.Media;

namespace WinFormsApp2;

public partial class SortArr : Form
{
    private SoundPlayer player_Error;
    private SoundPlayer player_Yashik;

    public int arrCount;
    private ArraySort arraySort;
    
    public SortArr()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;
        this.MaximizeBox = false;
        
        player_Error = new SoundPlayer(@"C:\Users\User\OneDrive\Desktop\основы программированния\laba6\WinFormsApp2\Ошибка.wav");
        player_Yashik = new SoundPlayer(@"C:\Users\User\OneDrive\Desktop\основы программированния\laba6\WinFormsApp2\ящики.wav");
        
        label2.Visible = false;
        button3.Visible = false;
        button4.Visible = false;
        button5.Visible = false;
        button6.Visible = false;
        dataGridView1.Visible = false;
        label3.Visible = false;
        label4.Visible = false;
        label5.Visible = false;
    }
    

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        if (!int.TryParse(textBox1.Text, out int a) || a <= 0)
        {
            label2.Visible = true;
        }

        else
        {
            arrCount = int.Parse(textBox1.Text);
            label2.Visible = false;
        }
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
        if (label2.Visible == false && textBox1.Text != "")
        {
            button1.Visible = false;
            button2.Visible = false;
            textBox1.Visible = false;

            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            
            arraySort = new ArraySort(arrCount);
            FillDataGridView();
            
             
            FillDataGridView();
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        textBox1.Text = "10";
    }
    
    private void FillDataGridView()
    {
        dataGridView1.Visible = true;

        dataGridView1.Columns.Clear();
        dataGridView1.Rows.Clear();

        dataGridView1.Columns.Add("Index", "№");
        dataGridView1.Columns.Add("Value", "Значение");
        
        dataGridView1.Columns[0].ReadOnly = true;
        dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable; 
        dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.LightGray; 
        dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.LightGray;
        dataGridView1.Columns[0].DefaultCellStyle.SelectionForeColor = Color.Blue;


        for (int i = 0; i < arrCount; i++)
        {
            dataGridView1.Rows.Add(i + 1, "");
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        ClearHighlights();
        label4.Visible = false;
        label3.Visible = false;
        label5.Visible = false;

        arraySort.InitializeRandomPublic();
        int[] arr = arraySort.GetArray();

        for (int i = 0; i < arrCount; i++)
            dataGridView1.Rows[i].Cells[1].Value = arr[i];
    }

    private void button4_Click(object sender, EventArgs e)
    {
        label4.Visible = false;
        label3.Visible = false;

        try
        {
            arraySort.UpdateFromDataGridView(dataGridView1);

            arraySort.SortInPlace();

            int[] sorted = arraySort.GetArray();

            for (int i = 0; i < arrCount; i++)
                dataGridView1.Rows[i].Cells[1].Value = sorted[i];

            ClearHighlights();
            
            player_Yashik.Play();
            MessageBox.Show("Массив успешно отсортирован!", "Готово",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            player_Yashik.Stop();
        }
        catch (FormatException ex)
        {
            player_Error.Play();
            MessageBox.Show($"Ошибка в данных: {ex.Message}", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            player_Error.Stop();
        }
        catch (Exception ex)
        {
            player_Error.Play();
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            player_Error.Stop();
        }
    }

    private void button5_Click(object sender, EventArgs e)
    {
        try
        {
            arraySort.UpdateFromDataGridView(dataGridView1);

            var (maxValue, maxIndex) = arraySort.FindMax();
            var (minValue, minIndex) = arraySort.FindMin();

            label3.Text = $"Максимальный: {maxValue} (позиция {maxIndex + 1})";
            label4.Text = $"Минимальный: {minValue} (позиция {minIndex + 1})";
            label3.Visible = true;
            label4.Visible = true;

            ClearHighlights();
            HighlightCell(minIndex, 1, Color.LightGreen);
            HighlightCell(maxIndex, 1, Color.LightCoral);
        }
        catch (Exception ex)
        {
            player_Error.Play();
            MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            player_Error.Stop();
        }
    }

    private void button6_Click(object sender, EventArgs e)
    {
        try
        {
            arraySort.UpdateFromDataGridView(dataGridView1);

            double average = arraySort.CalculateAverage();
            label5.Text = $"Среднее арифметическое: {average:F2}";
            label5.Visible = true;
        }
        catch (Exception ex)
        {
            player_Error.Play();
            MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            player_Error.Stop();
        }
    }
    
    
    private void HighlightCell(int rowIndex, int columnIndex, Color color)
    {
        if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
        {
            dataGridView1.Rows[rowIndex].Cells[columnIndex].Style.BackColor = color;
        }
    }
    
    private void ClearHighlights()
    {
        for (int i = 0; i < arrCount; i++)
        {
            dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.White;
        }
    }

    private void button7_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}