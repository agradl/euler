using System;
using Helpers;
using System.Linq;

namespace Problems {
    /*
    Special Pythagorean triplet
    Problem 9
    A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

    a^2 + b^2 = c^2
    For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

    There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    Find the product abc.
    */
    
    /*
                 a^2 + b^2 = (1000 - b - a)^2
                 a^2 + b^2 = 1000(1000 - b - a) - b(1000 - b - a) - a(1000 - b - a)
                 a^2 + b^2 = 1000000 - 1000b - 1000a - 1000b + b^2 + ab - 1000a + ab + a^2
                         0 = 1000000 - 2000b - 2000a + 2ab
       2000a + 2000b + 2ab = 1000000
           a + b + ab/1000 = 500                  
    */
    public class Problem9 : AProblem {
        public override Int64? CorrectAnswer { get { return 31875000;}}
        public override Int64 Solve(){
            for (int a = 1; a < 499; a++)
            {
                // a < b < c
                for (int b = (a + 1); b < 1000 - a - 1; b++)
                {
                    // 1000 = a + b + c
                    int c = 1000 - b - a;
                    if (Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2)){
                        return a*b*c;
                    }
                    
                }
            }
            throw new Exception("Not found!");
        }
    }
}