Console.Write("身長を入力してください(m)");
double height = Convert.ToDouble(Console.ReadLine());
Console.Write("体重を入力してください(kg)");
double weight = Convert.ToDouble(Console.ReadLine());
double bmi = weight / (height * height);

Console.WriteLine("<html><body>");
Console.WriteLine("<table border>=\"2\">");
Console.WriteLine($"<tr><td>身長</td><td>{height}</td></tr>");
Console.WriteLine($"<tr><td>体重</td><td>{weight}</td></tr>");
Console.WriteLine($"<tr><td>BMI</td><td>{bmi}</td><tr>");
Console.WriteLine("</table>");
Console.WriteLine("</body></html>;");