namespace project
{
    class test1
    {
        private int input1;
        private int input2;
        public int Input1
        {
            get { return input1; }
            set { input1 = value; }
        }
        public int Input2
        {
            get { return input2; }
            set { input2 = value; }
        }
        public test1() { }
        public test1(int Input1, int Input2)
        {
            input1 = Input1;
            input2 = Input2;
        }
        public void show()
        {
            for (int i = input1; i <= input2; i++)
            {
                int c = 0;
                int x = 1;
                for (int j = 1; j <= i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
                for (x = 1; x <= i; x++)
                {
                    if (c < 2)
                    {
                        Console.WriteLine(x);
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
    class test2
    {
        public static void Main()
        {
            Console.WriteLine("Please enter two numbers");
            int int1 = Convert.ToInt32(Console.ReadLine());
            int int2 = Convert.ToInt32(Console.ReadLine());
            test1 ts = new test1(int1, int2);
            ts.show();
        }
    }
}