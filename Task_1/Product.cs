using System.Diagnostics;

namespace Task_1
{
    public class Product : Money
    {
        public string? ProductName { get; set; }

        public void ReducePrice(decimal number)
        {
            int integerPart = (int)number;
            int cents = (int)((number - integerPart) * 100);
            if (integerPart < IntegerPart || (integerPart == IntegerPart && cents <= Cents))
            {
                IntegerPart -= integerPart;
                Cents -= cents;

                if (Cents < 0)
                {
                    IntegerPart -= 1;
                    Cents += 100;
                }
            }
            else
            {
                throw new Exception("Can't reduce price");
            }
        }
    }
}
