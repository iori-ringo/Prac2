Console.Write("身長を入力してください(m)");
double height = Convert.ToDouble(Console.ReadLine());
//Console.ReadLine()で1行読み込む
Console.Write("体重を入力してください(kg)");
double weight = Convert.ToDouble(Console.ReadLine());
//Convert.To型名　で引数を指定の方に変換
double bmi = weight / (height * height);

Console.WriteLine("<html><body>");
Console.WriteLine("<table border>=\"2\">");
Console.WriteLine($"<tr><td>身長</td><td>{height}</td></tr>");
//$で{}内の変数に指定してそれ以外を文字列で出力
Console.WriteLine($"<tr><td>体重</td><td>{weight}</td></tr>");
Console.WriteLine($"<tr><td>BMI</td><td>{bmi:F2}</td><tr>");
//{引数:F2}で小数点以下第二までしか表示しない(:D5だったら整数部分に0が指定のけた分増加する)
Console.WriteLine("</table>");
Console.WriteLine("</body></html>;");