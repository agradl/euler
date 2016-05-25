using System;
using System.Collections.Generic;

public static class Extensions {
    public static bool IsPalindromic(this int number){
        var strNum = number.ToString();
        var array = strNum.ToCharArray();
        Array.Reverse(array);
        
        return strNum == String.Join("",array);
    }
    
    public static bool IsDivisibleBy(this int number, params int[] divisors){
        foreach (var divisor in divisors)
        {
            if (number % divisor != 0)
            {
                return false;
            }
        }
        return true;
    }

    
    public static T Last<T>(this List<T> list){
        return list[list.Count - 1];
    }
    
    public static Int64 NthTriangularNumber(this Int64 n){
        return (n*n + n) / 2;
    }
}