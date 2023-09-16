using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
        if ((number > 9999) && (number < 100000))
        {
          int a = number/10000;
          int b = number%10000/1000;
          int c = number%100/10;
          int d = number%10;
          if ((a == d) && (b == c))
          {
            return true;
          }
                else 
                {
                  return true;
                }
        }
      else 
      {
        System.Console.WriteLine("Число не пятизначное");
        return false;
      }
}
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}