using System;
using Helpers;

namespace Problems {
    /*
    Largest palindrome product
    Problem 4
    A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

    Find the largest palindrome made from the product of two 3-digit numbers.
    */
    public class Problem4 : AProblem {
        public override Int64? CorrectAnswer { get { return 906609;}}
        public override Int64 Solve(){
            var max = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    if ((i*j).IsPalindromic()){
                        max = Math.Max(i*j, max);
                    }
                }    
            }
            
            return max;
        }
        
        public override void Test(){
            Assert.IsTrue(121.IsPalindromic());
            Assert.IsTrue(1221.IsPalindromic());
            Assert.IsTrue(13211231.IsPalindromic());
            Assert.IsFalse(1321.IsPalindromic());
            Assert.IsFalse(12334421.IsPalindromic());
        }
    }
}