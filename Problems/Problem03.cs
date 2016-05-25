using System;
using Helpers;

namespace Problems {
    /*
    Largest prime factor
    Problem 3
    The prime factors of 13195 are 5, 7, 13 and 29.

    What is the largest prime factor of the number 600851475143 ?
    */
    public class Problem3 : AProblem {
        public override Int64? CorrectAnswer { get { return 6857;}}
        public override Int64 Solve(){
            var dividend = 600851475143;
            int prime;
            for (prime = 2; prime < dividend; prime++)
            {
                if (dividend % prime == 0){
                    dividend = dividend / prime;
                    prime--;
                }
            }
            
            return prime;
        }
    }
}