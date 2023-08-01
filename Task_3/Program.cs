/*
 Завдання 3 (Структури)

    Створіть структуру «Десяткове число». 

    Визначте в ній необхідні поля і методи. Реалізуйте наступну функціональність: 

        ■ Перевести число у двійкову систему; 

        ■ Перевести число у вісімкову систему; 

        ■ Перевести число у шістнадцяткову систему.
 */

using Task_3;


DecimalNumber decimalNumber = new DecimalNumber();

while (true)
{
    Console.Write("Enter number here: ");
    try
    {
        decimalNumber.InputNumber(int.Parse(Console.ReadLine()));
        break;
    }
    catch { Console.WriteLine("Incorrect type! Please try again."); }
}

Console.WriteLine("Converted: ");
Console.WriteLine(decimalNumber.ToBinary());
Console.WriteLine(decimalNumber.ToOctal());
Console.WriteLine(decimalNumber.ToHexadecimal());


