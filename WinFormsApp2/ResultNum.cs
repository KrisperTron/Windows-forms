namespace WinFormsApp2;

public class ResultNum
{
    public static double Task(int a)
    {
        const double E = Math.E;
        double sinA = Math.Sin(a * Math.PI / 180);
        double tgA = Math.Tan(a * 2 * Math.PI / 180);
        double logE = Math.Log(Math.Pow(E, 2), 3);
        return Math.Round((sinA + tgA) / Math.Sqrt(logE), 2);
    }
}