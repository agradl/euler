using System;
using Helpers;

namespace Problems {
    /*
    Summation of primes
    Problem 10
    The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

    Find the sum of all the primes below two million.
    */
    public class Problem10 : AProblem {
        private const int MAX = 2000000;
        public override Int64? CorrectAnswer { get { return 142913828922;}}
        public override Int64 Solve(){
            int i = 0;
            Int64 sum = 0;
            while (Prime.Numbers[i] < MAX){
                sum = sum + Prime.Numbers[i];
                i++;
            }
            return sum;
        }
        
        
        public override void Test(){
            Assert.IsTrue(
                Prime.Numbers[Prime.Numbers.Count - 1] > MAX, 
                String.Format("Need primes less than {0}, found max prime of {1} - better calculate more", MAX, Prime.Numbers[Prime.Numbers.Count - 1]));
        }
    }
}