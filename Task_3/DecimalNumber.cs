namespace Task_3
{
    public struct DecimalNumber
    {
        private int _number;

        public void InputNumber(int number)
        {
            _number = number;
        }

        public string ToBinary()
        {
            return "Binary: " + Convert.ToString(_number, 2);
        }

        public string ToOctal()
        {
            return "Octal: " + Convert.ToString(_number, 8);
        }

        public string ToHexadecimal()
        {
            return "Hexadecimal: " + Convert.ToString(_number, 16);
        }
    }
}
