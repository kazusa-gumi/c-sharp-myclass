// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


//Console.WriteLine("文字を入力してください");
//string input = Console.ReadLine();
//Console.Write("入力文字:");
//Console.WriteLine(input);
//Console.ReadKey();


//using System;

//namespace HelloWorld
//{
// C#はclass内で実行される
//    class Program
//    {aaa
// C#はmain関数で開始・終了する
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

//Console.WriteLine("Hello World!");

//int x;
//x = 5;
//Console.WriteLine(x);



namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            // 10　ライブラリ
            // .NETクラスライブラリのSystem.Raddomクラスを使用
            // diceをサイコロとしてものとして、オブジェクトとして見ましょうって感じ
            Random dice = new Random();

            // diceオブジェクトのNext()メソッドを呼び出す
            int roll = dice.Next(1, 7);
            // ConsoleクラスのWriteLine()メソッドを呼び出す
            Console.WriteLine(roll);
            int roll1 = dice.Next(1, 7);
            Console.WriteLine(roll1);
            int roll2 = dice.Next(1, 7);
            Console.WriteLine(roll2);
            int roll3 = dice.Next(1, 7);
            Console.WriteLine(roll3);
            int roll4 = dice.Next(1, 7);
            Console.WriteLine(roll4);

            // 11　続ライブラリ
            //ステートレスメソッド: すでにメモリに入っている値を参照しない 過去の記憶は使用しない
            Console.WriteLine('a'); // WriteLineの中に入っているものだけ見ればOKみたいな

            //ステートフルメソッド（若干手続きある、Randomに一旦コピーしないといけないし）
            // メモリ内に入った値を参照し、更新する。
            // ob = クラスのインスタンス（オブジェクト）
            Random ob = new Random(); // newの箇所でメモリを確保、オブジェクトを生成, Randomは時刻に基づいた乱数生成
            int roll5 = ob.Next(1, 7);
            Console.WriteLine(roll5);

            // 12　オーバーロード
            // 1: 引数に様々なデータ型を使用できる
            // 2: 引数の数を選ぶことができる 引数渡したら戻り値帰ってくる

            int x = 1;
            Console.WriteLine(x);// int型
            Console.WriteLine("Good");// string型

            Random rand = new Random();
            int rand1 = rand.Next();
            Console.WriteLine(rand1);
            int rand2 = rand.Next(100);
            Console.WriteLine(rand2);
            // 90~99までしか取らない。maxValueは100入れない。minValueは90も含める
            int rand3 = rand.Next(90, 100);
            Console.WriteLine(rand3);
            // https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-7.0 でメソッドの種類も確認OK

            // 13　if文（分岐）ifはbool型
            // x >y, x<=y, x===y, x!=y
            // C#をAzureにupする方法確認
            var dice1 = new Random(); // varは型推定
            int roll6 = dice1.Next(1, 7);
            Console.WriteLine(roll6);

            if(roll6 >= 5)
            {
                Console.WriteLine("Very good!");
            } else if(roll6 >= 3)
            {
                Console.WriteLine("so good!");
            }
            else
            {
                Console.WriteLine("Bad..");
            }
            // 14　配列
            string[] item = new string[3];
            item[0] = "A123";
            item[1] = "B456";
            item[2] = "C789";
            Console.WriteLine(item[0]);
            Console.WriteLine(item[1]);
            Console.WriteLine(item[2]);

            // string[]で型宣言
            string[] fluits = { "apple", "orange", "pine" };
            Console.WriteLine(fluits[1]);
            // 配列に何個入っているかのメソッド
            Console.WriteLine(fluits.Length);

            // 15　foreach文
            // fluit は新しく宣言されたもの　インテレータ:順番に調べる, 0から順番に並べる
            foreach (string fluit in fluits)
            {
                Console.WriteLine(fluit);
            }
            Console.WriteLine();

            for(int i=0; i < fluits.Length; i++)
            {
                Console.WriteLine(@"#############");
                Console.WriteLine(fluits[i]);
                Console.WriteLine(@"#############");
            }
        }
    }
}