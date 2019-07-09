using System;

namespace TestDelegate
{
    //T moze biti bilo koja vrednost, u zagradi mu stavljamo potpis.
    //Potpis vazi za samo onu metodu koja se poklapa sa nasim potpisom.
    delegate T NumberChanger<T>(T n);

    class Program : IBaseInterface<string>
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            //Create delegate instances
            NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);

            //Calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine($"Value of Num: {getNum()}");
            nc2(5);
            Console.WriteLine($"Value of Num: {getNum()}");
        }
    }
}
