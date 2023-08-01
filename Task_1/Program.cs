/*
Завдання 1 (ООП)

Запрограмуйте клас Money (об'єкт класу оперує однією валютою) для роботи з грошима. 

У класі мають бути передбачені: поле для зберігання цілої частини грошей (долари, євро, гривні тощо) і поле для зберігання копійок (центи, євроценти, копійки тощо) 

Реалізувати методи виведення суми на екран, задання значень частин (цілої частини грошей та копійок). 

На базі класу Money створити клас Product для роботи з продуктом або товаром. 

Реалізувати метод, який дозволяє зменшити ціну на задане число. 

Для кожного з класів реалізувати необхідні методи і поля. 

Додати iнкапсуляцiю до полiв та методiв якщо треба.
*/

using Task_1.Classes;

Product product = new Product();


while (true)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Whose your option");
    Console.WriteLine("1. Fill money");
    Console.WriteLine("2. Reduce amount");
    Console.WriteLine("3. Show money amount");
    Console.WriteLine("4. Exit");
    Console.Write(">>>");
    string key = Console.ReadLine();

    switch (key)
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.Blue;
            FillMoney();
            break;
        case "2":
            Console.ForegroundColor = ConsoleColor.Green;
            ReduceAmount();
            break;
        case "3":
            Console.ForegroundColor = ConsoleColor.Magenta;
            product.ShowMoney();
            break;
        case "4":
            return;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong type. Try again.");
            break;
    }
}

void InputNumber(out decimal number)
{
    while (true)
    {
        try
        {
            Console.Write("Please enter number here: ");
            number = decimal.Parse(Console.ReadLine());
            break;
        }
        catch
        {
            Console.WriteLine("Incorect type. Please try agian.");

        }
    }
}

void ReduceAmount()
{
    decimal amountToSubstract;



    while (true)
    {
        try
        {
            InputNumber(out amountToSubstract);
            product.ReducePrice(amountToSubstract);
            break;
        }
        catch
        {
            Console.WriteLine("Entered number must be less than current amount.");
        }
    }
}

void FillMoney()
{
    Console.Write("Enter product name here: ");
    product.ProductName = Console.ReadLine();
    decimal money;
    InputNumber(out money);
    product.SetMoney(money);
}