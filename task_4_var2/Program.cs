
Console.Write("Введите число = ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0; // счетчик четных числел
int j =0; // счетчик чисел до введенного

while (j<N )
{
      if ((N-j) %2 == 0)
 {Console.Write($"{N-j},");
 count = count+1;
 if (j == (N-1))
 {
    Console.Write($"{N-j}");
 }
 j = j+1;
  }
 
else {j = j+1;}

}



