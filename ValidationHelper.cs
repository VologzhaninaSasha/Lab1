/// <summary>
/// Проверка корректности входных данных
/// </summary>
public static class ValidationHelper
{
    /// <summary>
    /// Проверка на 0
    /// </summary>
    /// <param name="value">Число для проверки на ноль</param>
    /// <param name="massege">Сообщение для вывода</param>
    /// <exception cref="ArgumentOutOfRangeException">Если значение равно 0 тогда выводится "massege"</exception>
    public static void CheckRange(double value, string massege)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), string.Format(massege));
        }
    }
}