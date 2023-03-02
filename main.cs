using System;
using System.Collections.Generic;
// Question: Check Sum

// You have to write a function which takes an array of integers "seq" and an integer "target". There exist two elements of the array whose sum is equal to the target. You can assume that there exists only one solution. You have to return the indices of those elements
// Example 1: Input = [1,9,2,19]  Target = 3
//Output  = 0,2

//Example 2:Input= [2,4]  Target = 6
//Output =0,1



class Program
{
    public static int[] TargetSum(int[] args, int target)
    {
        var sumValue = new Dictionary<int, int>();
        for (int i = 0; i < args.Length; i++)
        {
            int Value = target - args[i];
            if (sumValue.ContainsKey(Value))
            {
                return new int[] { sumValue[Value], i };
            }
            sumValue[args[i]] = i;
        }
        return null;
    }
    public static void DuplicateLetters()
    {
        string[] words = {"browser", "brother", "brand", "andy"};
        Dictionary<char, int> Counts = new Dictionary<char, int>();
        foreach (var word in words)
        {
            HashSet<char> duplicateLetters = new HashSet<char>();
            foreach (char letter in word)//browser
            {
                if (duplicateLetters.Contains(letter))
                {
                    if (Counts.ContainsKey(letter))
                    {
                        Counts[letter]++;
                    }
                    else
                    {
                        Counts.Add(letter, 2);
                    }
                }
                else
                {
                    duplicateLetters.Add(letter);//browse
                }
            }
        }
        foreach (KeyValuePair<char, int> letter in Counts)
        {
            Console.WriteLine($"{letter.Key}:{letter.Value}");
        }

    }
    public static void Main(string[] args)
    {
        DuplicateLetters();
        // int[]Numbers={1,9,2,19};
        // var numbers= TargetSum(Numbers,3);
        // var sumNumbers=string.Join(",",numbers);
        //   Console.WriteLine(sumNumbers);
        Console.WriteLine("Hello World");
    }

    // Question: Common letters and their frequencies
    // Given an array of words, find the letters that occur in more than one word. Also, find the count of words in which they occur. Return the letters with their count.

    // Example 1:
    // Input: words = ["browser","brother","brand","andy"]
    // Output: b:3,r:3,o:2,e:2,a:2,n:2,d:2

    // Example 2:
    // Input: words = ["cat","dog","zebra"]
    // Output: a:2

    // Example 3:
    // Input: words = ["car","wish"]
    // Output: ""

}