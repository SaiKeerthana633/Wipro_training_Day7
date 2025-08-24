class ABC
{
    public delegate int Add(int a, int b);
    public delegate void Print(int sum);


        public static void Main(string[] args)
    {
        Add d = admint;
        Print p = print;
        int n = d(232, 435);
        p(n);

       
    }
    public static int admint(int tutionfee, int transportfee) {
        return tutionfee+transportfee;
    }
    public static void print(int c) {
        Console.WriteLine("The total amout:"+c);
     }
}
