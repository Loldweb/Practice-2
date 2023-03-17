///1

/*using System;
class Student
{
    public string name, lastName, dateOfBirth;
    public int num_group;
    public int[] grades;
    
    static void Main()
    {
        Student stud = new Student();
        stud.name = "Ivan";
        stud.lastName = "Ivanov";
        stud.dateOfBirth = "2004.03.14";
        stud.num_group = 621;
        stud.grades = new[] {2, 4, 3, 5, 3};
        var str = string.Join(" ", stud.grades);
        bool los = true;
        while(los)
        {
            try
            {
                Console.WriteLine("\nВыберите что изменить :\n1 - Фамилию\n2 - дату рождения\n3 - номер группы\n4 - Вывести инф-ю");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        stud.lastName = Console.ReadLine();
                        break;
                    case 2:
                        stud.dateOfBirth = Console.ReadLine();
                        break;
                    case 3:
                        stud.num_group = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine($"Имя : {stud.name}\nФамилия : {stud.lastName}\nДата рождения : {stud.dateOfBirth}\nНомер группы : {stud.num_group}\nУспеваемость : {str}");
                        break;
                    default:
                        Console.WriteLine($"Имя : {stud.name}\nФамилия : {stud.lastName}\nДата рождения : {stud.dateOfBirth}\nНомер группы : {stud.num_group}\nУспеваемость : {str}");
                        los = false;
                        break;
                }
            }
            catch
            {
                Console.WriteLine($"\nИмя : {stud.name}\nФамилия : {stud.lastName}\nДата рождения : {stud.dateOfBirth}\nНомер группы : {stud.num_group}\nУспеваемость : {str}");
                break;
            }
        }
    }
}
///2

using System;
class Train
{
    public string destination, time;
    public int num_train;
    
    static void Main()
    {
        Train bif= new Train();
        bif.destination = "Moscow";
        bif.time = "12:30";
        bif.num_train = 123;
        bool los = true;
        while(los)
        {
            try
            {
                Console.WriteLine("\nВыберите что изменить :\n1 - номер\n2 - инф-я");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        bif.num_train = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine($"Пункт назначения : {bif.destination}\nВремя : {bif.time}\nНомер поезда : {bif.num_train}");                        
                        break;
                    default:
                        Console.WriteLine($"Пункт назначения : {bif.destination}\nВремя : {bif.time}\nНомер поезда : {bif.num_train}");                        
                        los = false;
                        break;
                }
            }
            catch
            {
                Console.WriteLine($"Пункт назначения : {bif.destination}\nВремя : {bif.time}\nНомер поезда : {bif.num_train}");                        
                break;
            }
        }
    }
}

///3

using System;

class Numbers
{
    public int num1, num2;


    public void Prints()
    {
        Console.WriteLine("Число 1: {0}", num1);
        Console.WriteLine("Число 2: {0}", num2);
    }

    public void ChangeNumbers(int n1, int n2)
    {
        num1 = n1;
        num2 = n2;
    }
    
    public int SumNumbers()
    {
        return num1 + num2;
    }

    public int MaxNumber()
    {
        return Math.Max(num1, num2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Numbers axa = new Numbers();
        axa.num1 = 1;
        axa.num2 = 2;
        Console.WriteLine("Введите первое число : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число : ");
        int nn = int.Parse(Console.ReadLine());
        axa.ChangeNumbers(n, nn);
        axa.Prints();

        Console.WriteLine("Сумма чисел: {0}", axa.SumNumbers());
        Console.WriteLine("Максимальное число: {0}", axa.MaxNumber());

    }
}
////4

using System;
class Counter
{
  public int status;
  static void Main()
  {
    Counter num = new  Counter();
    num.status = 0;
    bool cDs = true;
    while(cDs)
    {
        Console.WriteLine("\nУвеличить на 1(+)  \nУменьшить на 1(-)");
        string procedure = Console.ReadLine();
        if (procedure == "+")
        {
            num.status++;
        }
        else if (procedure == "-")
        {
            num.status--;
        }
        else
        {
            Console.WriteLine("\nERR" + $"\n{num.status}");
            break;
        }
        
        Console.WriteLine(num.status);            
    }
  }
}

///5

using System;

class MyClass
{
    private int myInt;
    private string myString;

    // Конструктор с входными параметрами
    public MyClass(int i, string s)
    {
        myInt = i;
        myString = s;
    }

    // Конструктор, инициализирующий свойства по умолчанию
    public MyClass()
    {
        myInt = 0;
        myString = "default";
    }

    // Деструктор
    ~MyClass()
    {
        Console.WriteLine("Объект удален");
    }

    // Метод для вывода свойств объекта
    public void ShowMe()
    {
        Console.WriteLine("myInt = {0}, myString = {1}", myInt, myString);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объекта с помощью конструктора с входными параметрами
        MyClass obj1 = new MyClass(10, "hello");
        obj1.ShowMe(); // Вывод: myInt = 10, myString = hello

        // Создание объекта с помощью конструктора по умолчанию
        MyClass obj2 = new MyClass();
        obj2.ShowMe(); // Вывод: myInt = 0, myString = default

        // Уничтожение объекта
        obj1 = null;
        obj2 = null;
        //GC.Collect();
        //GC.WaitForPendingFinalizers();
    }
}

*/

