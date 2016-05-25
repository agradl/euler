using System;
using System.Collections.Generic;

public static class Triangle {
    public static List<Int64> Numbers = new List<Int64>() {1};
    static Triangle() {
        Int64 max = 10000000;
        Int64 i = 2;
        while (Numbers.Last() < max){
            Numbers.Add(Numbers.Last() + i);
            i++;
        }
    }
}