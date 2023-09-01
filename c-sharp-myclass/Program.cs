using System;
// 名前空間
namespace HelloWorld
{

    // クラス
    class Program
    {
        public static int Addition()
        {
            int x = 5;
            int y = 10;
            int z = x + y;
            return z;
        }

        public static int Subtraction()
        {
            int x = 5;
            int y = 10;
            int z = x - y;
            return z;
        }


        static void Main(string[] args)
        {
            
            Console.WriteLine(Addition());
            Console.WriteLine(Subtraction());
        }
    }
}