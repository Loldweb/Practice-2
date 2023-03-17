///1

using System;
class Rocks
{
  static void Main() 
  {
       int a = 0;
      string J = "abc";
      string S = "odnfonsfgabcdsasda";
      for (int i = 0; i < S.Length; i++)
      {
          for ( int k = 0; k < J.Length; k++)
          {
                if (S[i] == J[k])
                {
                    a += 1;
                }
          }
      }
      Console.Write(a);
  }
}
///2

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] candidates = { 1, 2, 3, 5, 6, 4};
        int target = 7;
        var result = CombinationSum(candidates, target);
        foreach (var combination in result)
        {
            Console.WriteLine(string.Join(", ", combination));
        }
    }

    static List<List<int>> CombinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var result = new List<List<int>>();
        FindCombinations(candidates, target, 0, new List<int>(), result);
        return result;
    }

    static void FindCombinations(int[] candidates, int target, int index, List<int> current, List<List<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = index; i < candidates.Length && candidates[i] <= target; i++)
        {
            if (i > index && candidates[i] == candidates[i - 1])
            {
                continue;
            }

            current.Add(candidates[i]);
            FindCombinations(candidates, target - candidates[i], i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}

///3

using System;
using System.Collections.Generic;
class Mums
{
  static void Main(string[] args) 
  {
      int[] nums = new int [] {1, 2, 3, 5 , 7};
      Console.WriteLine(repetition(nums));
  }
  static bool repetition(int[] nums)
  {
      for (int i = 0; i < nums.Length; i++)
      {
          for (int j = i + 1; j < nums.Length; j++)
          {
              if (nums[i] == nums[j])
              {
                  return true;
              }
              
          }
      }
      return false;
  }
}
