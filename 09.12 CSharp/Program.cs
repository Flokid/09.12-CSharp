using System;
using System.Collections.Generic;
using System.Dynamic;
namespace _09._12_CSharp
{
    class Program
    {
        /* static void Addition(params int[] integer)//params передача значения необязательно(в 3 случае показанно)
         {
             int result = 0;
             for(int i=0;i<integer.Length;i++)
             {
                 result += integer[i];
             }
             Console.WriteLine(result);
         }
         static void Main(string[] args)
         {
             Addition(1, 2, 3, 4, 5);//15
             int[] array = new int[] { 1, 2, 3, 4 };
             Addition(array);//10

             Addition();//0 (но сначала должно быть определенное значение(не должно быть 0, может не понять сам компилятор)
             Console.ReadLine();

         }
        */
        /*static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;//(это ограничение на х(остановка))
            }
            else
            {
                return x * Factorial(x - 1);//рекурсия(условие при котором рекурсия закончится(бесконечный цикл))
            }//                     сдесь х уменьшается и возвращается на х-1(было 5 стало 4)
        }
        static void Main(string[] args)
        {
            int a = Factorial(5);
            Console.WriteLine(a);
            Console.ReadKey();
        }
        */
        /*static int Fibonachchi(int n)
        {
            if(n==0)
            {
                return 0;
            }
            if(n==1)
            {
                return 1;
            }
            else
            {
                return Fibonachchi(n - 1) + Fibonachchi(n - 2);
            }
        }
        static void Main(string[] args)
        {
            int a = Fibonachchi(13);
            Console.WriteLine(a);
            Console.ReadKey();
        }
        */
        //контекст класса class program(от "{" до "}")
        //контекст метода(после класса после  статик int d(он будет виден всем кодом))
        //контекст кода(int d в статике(будет виден  блоку(новому{}))



        /*static int a = 9;//переменная класса
        static void Main(string[] args)
        {
            int a = 5;//скрыла а=9,уровень метода(после  для других кодов а будет=9)
            Console.WriteLine(a);
        }   
        */


        /*static void Main(string[] args)
        {
            dynamic x = 3;//x-int
            Console.WriteLine(x);
            x = "Привет мир";//динамик сам определяет что за тип+еще может изменяться по ходу работы
            Console.WriteLine(x);
            x = new Person() { Name = "Tom", Age = 23 };//x- объект Person
            Console.WriteLine(x);
            Console.ReadLine();
            //new -создание(конструктор)
        }
        class Person
        {
            public  string Name{ get; set; }//{get;set; } брать и устанавливать
            public  int Age { get; set; }

            public override string ToString()
            {
                return Name + ',' + Age.ToString()+ " Года";
            }
        */
        /*static void  Main(string[] args)
        {
            dynamic x;
            x = new Person() { Name = "Tom", Age = 23 };//x- объект Person
            Console.WriteLine(x);
            dynamic z = x.getSalary(3, "string");
            dynamic y = new Person { Name = "Olya", Age = 20 };
            dynamic a = y.getSalary(3, "int");
            Console.WriteLine(y);
            Console.ReadKey();
        }
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
             public  dynamic getSalary(dynamic value,string format)
            {
                if(format=="string")
                {
                    return value + "рублей";
                }
                else if(format=="int")
                {
                    return value;
                }
                else
                {
                    return 0.0;
                }
            }
            public override string ToString()
            {
                return Name + ',' + Age.ToString() + " Года";
            }
        }
        */
        /*static void Main(string[] args)
        {
            dynamic viewbug = new System.Dynamic.ExpandoObject();
            viewbug.Name = "Tom";
            viewbug.Age = 46;
            viewbug.Languages = new List<string> { "english", "german","french" };//однонаправленная очередь
            Console.WriteLine("{0} - {1}", viewbug.Name, viewbug.Age);
            foreach (var lang in viewbug.Languages)
                Console.WriteLine(lang);
            //объявляем  метод
            viewbug.IncrementAge = (Action<int>)(x => viewbug.Age += x);
            viewbug.IncrementAge(6);//увеличиваем возраст на 6
            Console.WriteLine("{0} - {1}", viewbug.Name, viewbug.Age);
        }
        */
        /*static void Main(string[] args)
        {
           dynamic person = new PersonObject();
           person.Name = "Tom";
           person.Age = 23;
           Func<int, int> Incr = delegate (int x)
           { person.Age += x; return person.Age; };
           person.IncrementAge = Incr;
           Console.WriteLine("{0} - {1}", person.Name, person.Age);
           person.IncrementAge(4);
           Console.WriteLine("{0} - {1}", person.Name, person.Age);
           Console.ReadKey();
       }
        */
        /*static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int x;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out x))
            {
                x *= x;
                Console.WriteLine("Квадрат числа: " + x);
            }
            else
            {
                Console.WriteLine("Неккорктный ввод");
            }
        }
        */
        /*static void Main(string[] args)
        {
            try
            {
            int x = 5;
            int y = x / 0;
            Console.WriteLine("Результат: {y}");

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"Возникло исключение {ex.Message}");
            }
        }
        */


    }
}
