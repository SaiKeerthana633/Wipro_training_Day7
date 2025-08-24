class Program
{
    public delegate int Add(int a, int b);
    public static int add(int a, int b)
    {
        return a+b;
    }
    public static int sub(int a, int b)
    {
        return a-b;
    }
    public static int mul(int a, int b)
    {
        return a*b;
    }
    public static int div(int a, int b)
    {
        return a/b;
    }
    public static void Display(int a, int b, Add o)
    {
        int result = o(a, b);
        Console.WriteLine(result);
    }
    static void Main()
    {
        Console.WriteLine("Enter first");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter operator");
        string op = Console.ReadLine().ToLower();
        Add opn = null;
        switch (op)
        {
            case "add":
                opn = add;
                break;
            case "sub":
                opn = sub;
                break;
            case "div":
                opn = div;
                break;
            case "mul":
                opn=mul;
                break;

        }
        Display(n1, n2, opn);

    }
}

