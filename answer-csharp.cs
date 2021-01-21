using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int divisor)
    {
        var list = new List<int>();
        if (divisor != 1)
        {
            foreach (var v in arr)
            {
                if (v % divisor == 0)
                    list.Add(v);
            }

            if (list.Count == 0)
                list.Add(-1);
        }
        else
        {
            list.AddRange(arr);
        }

        list.Sort();

        return list.ToArray();
    }
}