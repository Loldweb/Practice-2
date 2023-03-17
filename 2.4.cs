using System;

class RomanNumerals 
{
    static void Main()
    {
        Console.Write("Введите римскую цифру: ");
        string romanNumeral = Console.ReadLine().ToUpper();
    
        int normal_num = 0;

        for (int i = 0; i < romanNumeral.Length; i++) 
        {
            char currentChar = romanNumeral[i];
            int currentValue = RomanNumeralValue(currentChar);

            if (i + 1 < romanNumeral.Length) 
            {
                char nextChar = romanNumeral[i + 1];
                int nextValue = RomanNumeralValue(nextChar);
                if (currentValue >= nextValue)
                {
                    normal_num += currentValue;
                } 
                else 
                {
                    normal_num -= currentValue;
                }
            }
            else
            {
                normal_num += currentValue;
            }
        }
        Console.WriteLine("Нормальный вид : " + normal_num);
    }

    static int RomanNumeralValue(char c) 
    {
        switch (c)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
}
