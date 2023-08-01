namespace Task_1
{
    public class Money
    {
        protected int IntegerPart { get; set; }
        protected int Cents { get; set; }

        public void ShowMoney()
        {
            Console.WriteLine("Сurrent amount: {0}.{1}", IntegerPart, Cents);
        }

        public void SetMoney(decimal money)
        {
            IntegerPart = (int)money;
            Cents = (int)((money - IntegerPart) * 100);
        }
    }
}
