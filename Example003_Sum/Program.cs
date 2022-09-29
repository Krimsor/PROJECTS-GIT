int numberA = new Random().Next(1,10);//int - целое число. 1,2,3,4 ...9
Console.WriteLine(numberA);// строка, чтобы выводить числа случайные, а не гадать какие были загаданы.
int numberB = new Random().Next(1,10);//new Random ().Next() - случайное число от() и до().
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);