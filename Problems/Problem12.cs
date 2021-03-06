using System;
using System.Collections.Generic;
using System.Linq;
using Helpers;

namespace Problems {
    /*
    Highly divisible triangular number
    Problem 12
    The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:

    1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...

    Let us list the factors of the first seven triangle numbers:

    1: 1
    3: 1,3
    6: 1,2,3,6
    10: 1,2,5,10
    15: 1,3,5,15
    21: 1,3,7,21
    28: 1,2,4,7,14,28
    We can see that 28 is the first triangle number to have over five divisors.

    What is the value of the first triangle number to have over five hundred divisors?
    */
    public class Problem12 : AProblem {
        public override Int64? CorrectAnswer { get { return 76576500;}}
        public override Int64 Solve(){
            //Nth Triangular Number is n(n+1) / 2
            
            Int64 index = 1;
            Int64 left = Divisors(index);
            Int64 right = Divisors(index + 1);
            while(right * left < 500){
                index += 1;
                left = right;
                right = Divisors(index + 1);
            }
            return index.NthTriangularNumber();
        }
        
        private Int64 Divisors(Int64 number){
            if (number % 2 == 0){ // discard one factor of 2 for the even number due to the `/ 2` part
                number = number / 2;
            }
            int index = 0, totalCount = 1, localCount = 0;
            while (number > 1){
                var divisble = number % Prime.Numbers[index] == 0;
                if (divisble){
                    number = number / Prime.Numbers[index];
                    localCount++;
                }
                if (divisble && number == 1 || !divisble){
                    totalCount = totalCount * (localCount + 1);
                    localCount = 0;
                    index++;
                }
            }
            
            return totalCount;
        }
        public override void Test(){
            Assert.AreEqual(Divisors(3), 2);
            Assert.AreEqual(Divisors(5), 2);
        }
    }
}