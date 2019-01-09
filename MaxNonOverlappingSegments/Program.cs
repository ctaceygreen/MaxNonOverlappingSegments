using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A, int[] B)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        //Since B is sorted, then this is nice and easy. We simply need to take the next segment which finishes the earliest (it's basically a scheduling problem)
        //With B sorted, just loop through A, take the segment, then continue through A that are greater than the recent B

        if (A.Length == 0)
        {
            return 0;
        }

        int maxNonOverlappingSegments = 1;
        long latestB = B[0]; // Latest end point. Always take the first element

        for(int i = 1; i < A.Length; i++)
        {
            if(A[i] > latestB)
            {
                maxNonOverlappingSegments++;
                latestB = B[i];
            }
        }
        return maxNonOverlappingSegments;
    }
}