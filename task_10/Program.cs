 Console.Write("Введите трехзначное число = ");
 double x = Convert.ToDouble(Console.ReadLine());
 double x1 = x / 100;
 double x2 = x /10;
 double x3 = x % 10;
 double result = Math.Floor((x1-Math.Floor(x1))*10);
 Console.WriteLine ($"Вторая цифра введенного числа: {result}");

