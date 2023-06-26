
public class Program
{
    public static void Main(string[] args)
    {
        Binary binary = new Binary();
        binary.CountBinary();
    }

    public class Binary
    {
        int[] numbers;
        public Binary()
        {
            numbers = new int[] { 1, 0, 1, 1, 1 };
            string numberString = string.Join("", numbers);
            int result = int.Parse(numberString);
            Console.WriteLine(result);

            int base1 = 1;
            int decimalValue = 0;

            while (result > 0)
            {
                int reminder = result % 10;
                result = result / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            Console.WriteLine($"Decimal value : {decimalValue}");
        }

        public void CountBinary()
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }



    }

}


// Tässä solution kataan, muista retunr ja alustaa parametsi oikein. 
// namespace Solution
// {
//   class Kata
//     {
//       public static int binaryArrayToNumber(int[] BinaryArray)
//         {
//             int[] numbers = BinaryArray;
//             string numberString = string.Join("", numbers);
//             int result = int.Parse(numberString);

//             int base1 = 1;
//             int decimalValue = 0;

//             while (result > 0)
//             {
//                 int reminder = result % 10;
//                 result = result / 10;
//                 decimalValue += reminder * base1;
//                 base1 = base1 * 2;
//             }

//             return decimalValue;
//         }
//     }
// }

