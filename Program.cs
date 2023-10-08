
public class Fider
{
    public static void Main(string[] args)
    {
        // оклад  за месяц
        var Salary = 8850;
        //длительность календарного месяца (28, 29, 30, 31)
        var durationmonth = 32;
        //Кол-во отработанных дней в месяце
        var OtrabDay = 20;

        //Заработная плата к получению за месяц
        var zpp = ZppCalculate.GetZpp(Salary, durationmonth, OtrabDay);
        Console.WriteLine($"Заработная плата к получению: {Math.Round(zpp, 2)}");
    }
}