// See https://aka.ms/new-console-template for more information
class AddandsubDelegate
{
    public delegate int Add(int a, int b);
    public delegate int Sub(int a, int b);
    public delegate void Printer(int result);   
    public static void Main(string[] args)
    {
        Add add = AddNumber;
        Sub subtract = SubNumber;
        Printer print = Pri;
        int c = add(4, 5);
        int d = subtract(8, 6);
        int e = int.Parse(Console.ReadLine());
        switch (e)
        {
            case 1: print(c); break;
            case 2: print(d); break;
        }
    }
    public static int AddNumber(int c, int b)
    {
        return c + b;
    }
    public static int SubNumber(int c, int b)
    {
        return c - b;
    }
    public static void Pri(int c)
    {
       Console.WriteLine(c);
    }
}