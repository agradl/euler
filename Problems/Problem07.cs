using System;
using Helpers;

namespace Problems {
    /*
    10001st prime
    Problem 7
    By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

    What is the 10 001st prime number?
    */
    public class Problem7 : AProblem {
        public override Int64? CorrectAnswer { get { return 104743;}}
        public override Int64 Solve(){
            return Prime.Numbers[10000];
        }
        
        public override void Test(){
            Assert.IsTrue(Prime.Numbers[0] == 2, "2");
            Assert.IsTrue(Prime.Numbers[1] == 3, "3");
            Assert.IsTrue(Prime.Numbers[2] == 5, "5");
            Assert.IsTrue(Prime.Numbers[3] == 7, "7");
            Assert.IsTrue(Prime.Numbers[4] == 11, "11");
            Assert.IsTrue(Prime.Numbers[5] == 13, "13");
        }
    }
}