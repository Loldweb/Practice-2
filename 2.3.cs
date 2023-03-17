/*
///1

using System;
class Worker
{
    public string name, surname;
    public int rate, days;
  static void GetSalary(int a, int b)
  {
     Console.Write($"Salary - {a * b}"); 
  }
  static void Main()
  {
      Worker axa = new Worker();
      axa.name = "Mark";
      axa.surname = "Pen";
      axa.rate = 200;
      axa.days = 15;
      GetSalary(axa.rate, axa.days);
  }    
}

/////2

using System;

public class Worker
{
        private string name;
        private string surname;
        private double rate;
        private int days;
    
        public Worker(string name, string surname, double rate, int days)
        {
            this.name = name;
            this.surname = surname;
            this.rate = rate;
            this.days = days;
        }

        public string Name
        {
           get { return name; }
        }       

        public string Surname
        {
            get { return surname; }
        }
    
        public double Rate
        {
            get { return rate; }
        }
        
        public int Days
        {
            get { return days; }
        }
        public double GetSalary()
        {
            return rate * days;
        }
    }

class Program
{
    static void Main(string[] args)
    {
        Worker worker = new Worker("Иван", "Иванов", 1000, 20);
        Console.WriteLine("Имя: " + worker.Name);
        Console.WriteLine("Фамилия: " + worker.Surname);
        Console.WriteLine("Ставка: " + worker.Rate);
        Console.WriteLine("Отработанные дни: " + worker.Days);
        Console.WriteLine("Зарплата: " + worker.GetSalary());
    }
}

////3

using System;
    public class Calculation
    {
        public string CalculationLine { get; private set; }

        public void SetCalculationLine(string line)
        {
            CalculationLine = line;
        }
    
        public void SetLastSymbolCalculationLine(char symbol)
        {
            CalculationLine += symbol;
        }
    
        public string GetCalculationLine()
        {
            return CalculationLine;
        }

        public char GetLastSymbol()
        {
            return CalculationLine[CalculationLine.Length - 1];
        }

        public void DeleteLastSymbol()
        {
            if (CalculationLine.Length > 0)
            {
                CalculationLine = CalculationLine.Remove(CalculationLine.Length - 1);
            }
        }
    }
    
public class Program
{
    static void Main()
    {
        Calculation calculation = new Calculation();
        calculation.SetCalculationLine("fds =fsd f-");
        calculation.SetLastSymbolCalculationLine('@');
        Console.WriteLine($"LINE : {calculation.GetCalculationLine()}");
        Console.WriteLine("Calculation line with added symbol: " + calculation.GetCalculationLine());
        Console.WriteLine("Last symbol: " + calculation.GetLastSymbol());
        calculation.DeleteLastSymbol();
        Console.WriteLine("Calculation line with last symbol removed: " + calculation.GetCalculationLine());
    }
}
*/
