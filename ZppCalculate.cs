/// <summary>
/// Заработная плата к получению за месяц
/// </summary>
public class ZppCalculate
{

    /// <summary>
    /// Максимальный рост в см.
    /// </summary>
    private const double MaxDayMonth = 31;
    /// <summary>
    /// Минимальный рост в см.
    /// </summary>
    private const double MinDayMonth = 28;

    /// <summary>
    /// Расчитать заработную плату к получению за месяц
    /// </summary>
    /// <param name="Salary">Оклад за месяц</param>
    /// <param name="DurationMonth">Длительность календарного месяца</param>
    /// <param name="OtrabDay">Количество отработанных дней в месяце</param>
    /// <returns>Заработная плата к получению за месяц</returns>
    public static double GetZpp(double salary, double durationmonth, double otrabday)
    {
        ValidationHelper.CheckRange(salary, "Оклад должен быть больше 0");

        ValidationHelper.CheckRange(otrabday, "Отработанное количество дней должено быть больше 0");

        if (durationmonth < MinDayMonth || durationmonth > MaxDayMonth)
        {
            throw new ArgumentOutOfRangeException(nameof(durationmonth),
                $"Количество дней в месяце должено быть в диапозоне от {MinDayMonth} до {MaxDayMonth}.");
        }

        return salary / durationmonth * otrabday;
    }
}
