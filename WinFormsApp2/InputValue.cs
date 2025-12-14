namespace WinFormsApp2;

public class InputValue
{
    /// <summary>
    /// Считает ввод с клавиатуры и проверяет правильность ввода целочисленного числа
    /// </summary>

    public static int CheckInt(string num)
    {
        return int.Parse(num);
    }
    
    
    /// <summary>
    /// Считает ввод с клавиатуры и проверяет правильность числа с плавующий точкой
    /// </summary>
    public static bool CheckDouble(TextBox tb, out double value)
    {
        if (double.TryParse(tb.Text, out value))
            return true;

        MessageBox.Show("Введите корректное число!", "Ошибка");
        tb.Focus();
        return false;
    }

    /// <summary>
    /// Проверяет правильность ввода массива
    /// </summary>
    public static bool CheckArray(TextBox tb, out int value)
    {
        if (int.TryParse(tb.Text, out value))
            return true;

        MessageBox.Show("Введите коректный массив", "Ошибка");
        tb.Focus();
        return false;
    }
}
