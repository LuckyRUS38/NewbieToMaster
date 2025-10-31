using System;
using System.Collections.Generic;

namespace NewbieToMaster;

public static class Tasks1
{
    public static void Task1()
    {
        string[] text = Console.ReadLine()!.Split(' ');
        Console.WriteLine(text.Length);
    }

    public static void Task2()
    {
        int hours = Convert.ToInt32(Console.ReadLine());
        int minutes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(hours * 60 + minutes);
    }

    public static void Task3()
    {
        string text = Console.ReadLine()!.ToLower();
        char[] vowels = ['а', 'е', 'и', 'ё', 'э', 'я', 'ы', 'о', 'ю'];
        char[] consonants =
            ['б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ'];
        int vCount = 0;
        int cCount = 0;

        foreach (var t in text)
        {
            foreach (var t1 in vowels)
            {
                if (t == t1)
                {
                    vCount++;
                }
            }

            foreach (var t1 in consonants)
            {
                if (t == t1)
                {
                    cCount++;
                }
            }
        }

        Console.WriteLine(cCount);
        Console.WriteLine(vCount);
    }

    public static void Task4()
    {
        int size = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= size; i++)
        {
            Console.Write(i + "\t");
            for (int j = 2; j <= size; j++)
            {
                Console.Write(i * j + "\t");
            }
            Console.WriteLine();
        }
    }

    public static void Task5()
    {
        string s = Console.ReadLine()!;
        string reversedWord = "";

        for (int i = s.Length - 1; i >= 0; i--)
        {
            reversedWord += s[i];
        }
        Console.WriteLine(reversedWord);
    }
}