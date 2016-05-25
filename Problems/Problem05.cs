using System;
using Helpers;

namespace Problems {
    /*
    Smallest multiple
    Problem 5
    2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

    What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    */
    public class Problem5 : AProblem {
        public override Int64? CorrectAnswer { get { return 232792560;}}
        public override Int64 Solve(){
            var factor = 0;
            var test = 20*19;
            while (factor == 0){
                //exclude numbers that can evenly divide larger numbers in the range
                //ex. if its divisble by 10, it is divisble by 2
                if (test.IsDivisibleBy(10,11,12,13,14,15,16,17,18,19)){
                    factor = test; 
                }
                //increment by 20 and skipp others
                test += 20;
            }               
            
            return factor;
        }
    }
}