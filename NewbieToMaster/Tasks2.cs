using System;
using System.Collections.Generic;
using System.Linq;

namespace NewbieToMaster;

public static class Tasks2
{
    public static void Task1()
    {
        string[] words = Console.ReadLine()!.Split(" ");
        int[] arr = new int[words.Length];
        for (int i = 0; i < words.Length; i++)
        {
            arr[i] = Convert.ToInt32(words[i]);
        }

        int counter = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] > arr[i])
            {
               counter++; 
            }
            else if (arr[i] > arr[i - 1])
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }

    public static void Task2()
    {
        string[] words = Console.ReadLine()!.Split(", ");
        Dictionary<string, int> dict = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (dict.ContainsKey(words[i]) == false)
            {
                dict.Add(words[i], i);
            }
        }

        foreach (var item in dict)
        {
            Console.WriteLine(item.Key);
        }
    }
}