namespace HelloWorld
{

    class Program
    {

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

            // GetTypeCodeは型を返すメソッド
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
    }
}