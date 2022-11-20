Random rnd = new Random();
  
int number_first = rnd.Next(1, 10);  //Получить очередное случайное число
Console.WriteLine(number_first);
int number_second = rnd.Next(1,20); //Получить очередное случайное число
Console.WriteLine(number_second);
int summ = number_first + number_second;

Console.WriteLine(summ);  //Вывод числа в консоль

