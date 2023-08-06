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
            // ①Const 宣言時は大文字の方がわかりやすい
            const int NUM = 5; // いじって欲しくないやつはconstで宣言
            int[] array = new int[NUM];
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;

            // 始まり、終わり、進める
            for (int i = 0; i < NUM; i++)
            {
                Console.WriteLine(array[i]);
            }

            // ②型推論 varは右辺から型を推論
            var x = 10;
            var y = 10.5m;

            // GetTypeCodeは型を返すメソッドaaa
            Console.WriteLine(x.GetTypeCode());
            Console.WriteLine(y.GetTypeCode());

            // 本来なら　Random randにしないといけない。どんな型で返ってくるかわからないときはvarで宣言するのも１つのやり方。
            var rand = new Random();
            int roll = rand.Next(1, 7);
            Console.WriteLine(roll);

            // ③メソッド
            // 自作メソッドは、コンポーネントみたいに何度も使い回しできるけど、流れがみにくい・・短い内容のメソッドは使用しなくてもいいかも。
            var x1 = 10;
            int y1;
            y1 = NewMethod(x1);
            printAnswer(y1);
            // ④名前空間、クラスで使用classAのsqrtメソッドを
            Console.WriteLine(A.sqrt(x));

            // ⑤配列
            int[] array1;// 宣言したがまだ生成されていない
            array1 = new int[3];// インスタンス生成、メモリ割り当て
            foreach (int a1 in array1)
            {
                Console.WriteLine(a1);
            }
            // ⑥拡大・縮小変換

            // int→decimalは拡大（情報が増える）ので自動で可能
            int a = 3;
            decimal number = a;
            Console.WriteLine(number);


            // decimal→intは縮小（情報が減る）ので指定が必要、宣言をしないとエラーでる。
            decimal z = 3.14m;
            int b = (int)z;
            Console.WriteLine(b);

            // 文字・数字変換
            int text = 3;
            int text2 = 5;
            // 文字型に変換可能 toString()
            string s = text.ToString() + text2.ToString();
            Console.WriteLine(s);

            string s1 = "3";
            string s2 = "5";

            // int.Parseで文字→数値に変換できる
            int sum = int.Parse(s1) + int.Parse(s2);
            Console.WriteLine(sum);
        }

        //引数
        private static void printAnswer(int y1)
        {
            Console.WriteLine(y1);
            Console.WriteLine(y1);
            Console.WriteLine(y1);
        }

        private static int NewMethod(int x1)
        {
            //返り値
            return x1 * x1;
        }

        // ④名前空間、クラス
        class A
        {
            public static int sqrt(int x)
            {
                return x * x + x;
            }
        }

        

        
    }
}