

using System;
using System.Collections.Generic;

public static class Prime {
    public static List<Int64> Numbers = new List<Int64>(){2,3,5,7};
    static Prime(){
        var maxPrimeValue = 3000000;
        Int64 i = 9;
        while (Numbers[Numbers.Count - 1] < maxPrimeValue)
        {
            if (IsPrime(i)){
                Numbers.Add(i);
            }
            i = i + 2;
        }    
    }
    
    private static bool IsPrime(Int64 number){
        var i = 0;
        Int64 current;
        do
        {
            current = Numbers[i];
            if (number % current == 0){
                return false;
            }   
            i++;
        } while (current <= Math.Sqrt(number));
        return true;
    }
}