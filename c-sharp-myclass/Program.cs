using System;
// 名前空間
namespace HelloWorld
{

    // クラス
    class Program
    {
        // メソッド
        static void Main(string[] args)
        {
            // while文
            int i = 0;
            int j = 3;
            while (i < j)
            {
                int MyInt1 = Convert.ToInt32(Console.ReadLine());
                int MyInt2 = Convert.ToInt32(Console.ReadLine());

                int Result = MyInt1 + MyInt2;
                Console.WriteLine("The Sum = " + Result);
                i++;
            }
            // for文
            for (i=0; i < 3; i++)
            {
                int MyInt1 = Convert.ToInt32(Console.ReadLine());
                int MyInt2 = Convert.ToInt32(Console.ReadLine());

                int Result = MyInt1 + MyInt2;
                Console.WriteLine("The Sum = " + Result);
                i++;
            }
        }
    }
}