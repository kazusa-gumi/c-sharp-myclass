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
            // “Hello World”と表示するプログラムを作成しなさい。
            Console.WriteLine("Hello world");
            

            //int 型の変数 x に数値 11 を代入し、xの値を“x=11”のように表示するプログラムを作成しなさい。
            int x = 11;
            Console.WriteLine("x= " + x);

            // int 型の変数 x、y に数値 13、17 を代入し、x、y の値を“x=13,y=17”のように表示するプログラムを作成しなさい。
            int x1 = 13;
            int y1 = 17;
            Console.WriteLine("x= " + x1);
            Console.WriteLine("y= " + y1);

            // int 型の変数 x に数値 13 と 17 の和を代入し、x の値を表示するプログラムを作成しなさい。
            int x2 = 13;
            int y2 = 17;
            Console.WriteLine(x2 + y2);

            //数値 13 と 17 の積を表示するプログラムを作成しなさい。ただし、変数を使用しないこと。
            Console.WriteLine(13 * 17);

            //次のプログラムを作成しなさい。
            //int 型の変数 x に数値 7 を代入する。
            //変数 x の値を 3 倍にする。
            //変数 x の値を表示する。
            //変数 x の値を半分（1 / 2）にする。
            //変数 x の値を表示する。

            int x3;
            x3 = 7;
            x3 = x3 * 3;
            x3 = x3 / 2;
            Console.WriteLine(x3);

            // int 型の変数 x、y に任意の数値を代入し、x の値を y に、y の値を x に入れ替えて x と y の値を表示するプログラムを作成しなさい。
            int x4;
            int y4;
            int t;

            x4 = 3;
            y4 = 7;

            t = x4;
            x4 = y4;
            y4 = t;
            // "x={0},y={1}" placeholderの役割をしている
            Console.WriteLine("x={0},y={1}", x4, y4);

            // int 型の変数 x、y に数値 19、23 を代入し、その積を変数 z に代入して z の値を表示するプログラムを作成しなさい。
            int x5, y5, z5;

            x5 = 19;
            y5 = 23;
            z5 = x5 * y5;
            Console.WriteLine(z5);

            // int 型の変数 x に任意の数値を代入し、x を 2 倍、3 倍、4 倍した結果を表示するプログラムを作成しなさい。
            int x6 = 2;
            Console.WriteLine(x6 * 2);
            Console.WriteLine(x6 * 3);
            Console.WriteLine(x6 * 4);

            // int 型の変数 x に任意の数値を代入し、x を 1 乗、2 乗、3 乗した結果を表示するプログラムを作成しなさい。
            int x7 = 4;
            Console.WriteLine(Math.Pow(x7, 1));
            Console.WriteLine(Math.Pow(x7, 2));
            Console.WriteLine(Math.Pow(x7, 3));

            //　以下でも可能
            Console.WriteLine(x7);
            Console.WriteLine(x7 * x7);
            Console.WriteLine(x7 * x7 * x7);

            // int 型の変数 x に任意の数値を代入し、x を x より小さい任意の数値で割った商と余りを表示するプログラムを作成しなさい。
            int x8 = 8;
            Console.WriteLine(x8 /4);

            //　int 型の変数 x に任意の数値を代入し、インクリメント演算子、デクリメント演算子を適用して結果を表示することにより演算子の効果を確認するプログラムを作成しなさい。
            int x9 = 10;
            x9++;
            Console.WriteLine(x9);
            x9--;
            Console.WriteLine(x9);
            x9--;
            Console.WriteLine(x9);

            // int 型の変数 x、y にそれぞれ数値を入力し、x が y より大きい場合に、“xはyより大きい”という文を表示するプログラムを作成しなさい。
            Console.WriteLine("数値を入れてね");
            int x10 = int.Parse(Console.ReadLine());
            Console.WriteLine("２つ目の数値を入れてね");
            int y10 = int.Parse(Console.ReadLine());

            if(y10< x10)
            {
                Console.WriteLine("xはyより大きい");
            } else
            {
                Console.WriteLine("xはyより小さい");
            }

            // int 型の変数 x、y にそれぞれ数値を入力し、x と y の和、差（x－y）、積、商と余り (x÷y)、を表示するプログラムを作成しなさい。
            Console.WriteLine("数値を入れてね");
            int x11 = int.Parse(Console.ReadLine());
            Console.WriteLine("２つ目の数値を入れてね");
            int y11 = int.Parse(Console.ReadLine());
            int add = x11 + y11;
            Console.WriteLine("和は" + add);
            int subtract = x11 + y11;
            Console.WriteLine("差は" + subtract);
            int product = x11 * y11;
            Console.WriteLine("積は" + product);
            int remainder = x11 / y11;
            Console.WriteLine("積は" + remainder);

            // ２つの整数値を入力し、平均値を求めるプログラムを作成しなさい。
            Console.WriteLine("平均値を求めますので、数値を２つ入れてね");
            int x12 = int.Parse(Console.ReadLine());
            Console.WriteLine("2つ目の数値を入れてね");
            int y12 = int.Parse(Console.ReadLine());

            int answer = (x12 + y12) / 2;
             Console.WriteLine(answer);


            // 年齢を訊ね、生まれてから現在までの、おおよその日数を表示するプログラムを作成しなさい。
            // ※日数の計算は閏年等を考慮せず、年齢× 365 とする。
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            int ageDate = 365 * age;
            Console.WriteLine("生まれてから " + ageDate + " 日経過してます。");

            // ２つの整数値を入力し、大きい方（小さくない方）の数を表示するプログラムを作成しなさい。
            Console.WriteLine("１つ目の数値を入れて下さい");
            int x13 = int.Parse(Console.ReadLine());
            Console.WriteLine("2つ目の数値を入れて下さい");
            int y13 = int.Parse(Console.ReadLine());

            if(x13 < y13)
            {
                Console.WriteLine(y13 + " の方が大きいです");
            } else
            {
                Console.WriteLine(x13 + " の方が大きいです");
            }

            // 正の整数値を入力し、それが偶数か奇数かを判定するプログラムを作成しなさい。

        }

    }
}