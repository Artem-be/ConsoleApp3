using System;

public class CustomConverter
{
    // Перегрузка для преобразования строки в int
    public bool Convert(string input, out int result)
    {
        return int.TryParse(input, out result);
    }

    // Перегрузка для преобразования строки в double
    public bool Convert(string input, out double result)
    {
        return double.TryParse(input, out result);
    }

    // Перегрузка для преобразования строки в bool
    public bool Convert(string input, out bool result)
    {
        return bool.TryParse(input, out result);
    }

    // Добавьте другие перегрузки по мере необходимости

    // Пример использования
    public static void Main()
    {
        CustomConverter converter = new CustomConverter();

        if (converter.Convert("123", out int intValue))
        {
            Console.WriteLine($"Converted to int: {intValue}");
        }
        else
        {
            Console.WriteLine("Failed to convert to int.");
        }

        if (converter.Convert("123.45", out double doubleValue))
        {
            Console.WriteLine($"Converted to double: {doubleValue}");
        }
        else
        {
            Console.WriteLine("Failed to convert to double.");
        }

        if (converter.Convert("true", out bool boolValue))
        {
            Console.WriteLine($"Converted to bool: {boolValue}");
        }
        else
        {
            Console.WriteLine("Failed to convert to bool.");
        }
    }
}
