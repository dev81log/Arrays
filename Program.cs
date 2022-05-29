namespace Arrays
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            var myArray = new int[7] { 3, 55, 60, 36, 10, 27, 16 };
            myArray[2] = 22;
            myArray[3] = 23;

            Console.WriteLine(myArray[2]);
            Console.WriteLine(myArray[3]);
            
            Console.WriteLine("===========");
            
            for (var index = 0; index < 7; index++)
            {
                Console.WriteLine(myArray[index]);
            }
        }
    }
}