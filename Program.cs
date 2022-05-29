namespace Arrays;

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

        for (var index = 0; index < 7; index++) // manual index assignment of the array
            Console.WriteLine(myArray[index]);


        Console.WriteLine("===========");

        foreach (var index in myArray) // automatic index assignment of the array
            Console.WriteLine(index);


        Console.WriteLine("===========");


        var offices = new Worker[2]; // length of the array
        offices[0] = new Worker() { NumberSecurity = 2244, Name = "Andrei" }; // constructor position of the array 
        offices[1] = new Worker() { NumberSecurity = 3355, Name = "Julius" };

        foreach (var office in offices)
            Console.WriteLine($"Number security: {office.NumberSecurity} Name: {office.Name}");
    }

    private struct Worker // struct representing Worker objects
    {
        public int NumberSecurity { get; set; }
        public string Name { get; set; }
    }
}