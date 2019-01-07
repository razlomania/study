using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Xml.Schema;
using static System.Console;

namespace SharpStudy
{
  public static class StringExtension
  {
    public static int WordCount(this string str, char c)
    {
      int counter = 0;
      for (int i = 0; i < str.Length; i++)
      {
        if (str[i] == c)
          counter++;
      }
      return counter;
    }
  }

  class Program
  {

    static int[] ArraySort(int[] ar)
    {
      int temp;
      for (int i = 0; i < ar.Length - 1; i++)
      {
        for (int j = i + 1; j < ar.Length; j++)
        {
          if (ar[i] > ar[j])
          {
            temp = ar[i];
            ar[i] = ar[j];
            ar[j] = temp;
          }
        }
      }
      return ar;
    }


    static int birthdayCakeCandles(int[] ar)
    {
      int max = ar[0];
      int counter = 1;

      for (int i = 1; i < ar.Length; i++)
      {
        if (max < ar[i])
        {
          max = ar[i];
          counter = 1;
          continue;
        }
        if (max == ar[i])
        {
          counter++;
        }
      }
      return counter;
    }

    static int GetDifference(int[,] arr)
    {
      int MainDiagonalSum = 0;
      int SecondaryDiagonalSum = 0;
      for (int i = 0; i < arr.GetLength(0); i++)
      {
        MainDiagonalSum += arr[i, i];
        SecondaryDiagonalSum = arr[i, arr.GetLength(0) - 1 - i];
      }
      return Math.Abs(MainDiagonalSum - SecondaryDiagonalSum);
    }

    static string IsWordPresent(string str)
    {
      string word = "hackerrank";
      int lastIndex = 0;
      foreach (char t in word)
      {
        var charFound = false;
        for (int i = lastIndex; i < str.Length; i++)
        {
          if (str[i] != t)
          {
            continue;
          }
          charFound = true;
          lastIndex = i + 1;
          break;
        }

        if (!charFound)
        {
          return "No";
        }

      }
      return "Yes";
    }

    static void Main(string[] args)
    {


      //           string s = "Hello world";
      //           char c = 'a';
      //           int i = s.WordCount(c);
      //           WriteLine(i);
      //
      //           WriteLine(IsWordPresent("hereiamstackerrank"));
      //
      //
      //            int[] arr = { 2, 3, 4, 4, 4, 4, 4, 3, 2 };
      //       
      //            WriteLine(GetDifference(new[,]
      //            {
      //                {11, 2,4 },
      //                {5,6,6 },
      //                {10, 8, -12 }
      //            }));
      //            WriteLine(birthdayCakeCandles(arr));
      //            WriteLine(MyMeth("1.2.3", "1.1.1"));
      //            WriteLine(MyMeth("1", "1.0"));
      //            WriteLine(MyMeth("1.1.1", "1.2.3"));
      //
      //WriteLine(UniqueChars("vova"));
      WriteLine(Fibonacci(10));                  
      //            WriteLine(RemoveDuplicate("vova"));

      ReadKey();
    }


    static int MyMeth(string str1, string str2)
    {
      var ar1 = str1.Split('.').Select(x => int.Parse(x)).ToArray();
      var int1 = FromArrayToInt(ar1);
      var ar2 = str2.Split('.').Select(x => int.Parse(x)).ToArray();
      var int2 = FromArrayToInt(ar2);

      if (int1 > int2)
      {
        return 1;
      }
      if (int1 == int2)
      {
        return 0;
      }

      return -1;
    }


    static string UniqueChars(string name)
    {
      Dictionary<char, int> dict = new Dictionary<char, int>();

      // O(n)
      foreach (var charecter in name)
      {
        if (dict.ContainsKey(charecter))
        {
          dict[charecter]++;
        }
        else
        {
          dict.Add(charecter, 1);
        }
      }

      var result = "";
      // O(n)
      foreach (var c in name)
      {
        if (dict[c] == 1)
        {
          result += c;
        }
      }

      return result;
    }

    static int FromArrayToInt(int[] args)
    {
      var result = args[args.Length - 1];
      var pow = 1;
      for (int i = args.Length - 2; i >= 0; i--)
      {
        result += (int)Math.Pow(10, pow++) * args[i];
      }

      for (int i = 0; i < args.Length; i++)
      {
        if (result % 10 != 0)
          break;
        result = result / 10;
      }

      return result;
    }

    static string RemoveDuplicate(string s)
    {
      string result = "";
      s.ToCharArray();

      for (int i = 0; i < s.Length; i++)
      {
        bool flag = false;
        for (int j = 0; j < s.Length; j++)
        {
          if (i != j && s[j] == s[i])
          {
            flag = true;
          }
        }

        if (!flag)
        {
          result += s[i];
        }
      }
      return result;
    }

    static int Fibonacci(int i)
    {
      if(i == 0)
      {
        return 0;
      }
      if(i ==1)
      {
        return 1;
      }
      else
      {
        return Fibonacci(i - 1) + Fibonacci(i - 2);
      }
    }
  }
}