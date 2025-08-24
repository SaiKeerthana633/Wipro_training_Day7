// See https://aka.ms/new-console-template for more information
class Multicatdelegate
 {

    // Delegate Declaration for add operations and Print 
    // parameterized Delegates responsible for method invocation at runtime
    public delegate int Operations(int a, int b);

    public delegate void PrintDelegate(int result);

    public static void Main(string[] args)
    {

        //Assign Methods to delegates
        //Member functions are encapsulated using delegate
        Operations Add = AddNumbers;
        Operations Subtract = SubtractNumbers;

        // calling/using delegate
        int result1 = Add(10, 30);
        int result2 = Subtract(10, 30);
        PrintDelegate print = PrintAdd;
        // PrintDelegate print2 = PrintSubtract;
        print += PrintResult;
        print(result1);
        print(result2);
    }
   public static int AddNumbers(int x, int y)
    { return x + y; }

    public static int SubtractNumbers(int x, int y)
    { return x - y; }

    public static void PrintAdd(int result)
    {
        Console.WriteLine("The result is :" + result);
    }
    public static void PrintResult(int result)
    {
        result = result * 10;
        Console.WriteLine("The result is :" + result);
    }
}



// create a delegate for a admin who is responsible for calculating the invoice(int tutionfess , int transportfees)
//and one more delegate which will print the invoice
