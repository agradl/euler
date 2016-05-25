using System;
using Helpers;

namespace Problems {
    /*
    Sum square difference
    Problem 6
    The sum of the squares of the first ten natural numbers is,

    1^2 + 2^2 + ... + 10^2 = 385
    The square of the sum of the first ten natural numbers is,

    (1 + 2 + ... + 10)^2 = 55^2 = 3025
    Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

    Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    */
    public class Problem6 : AProblem {
        public override Int64? CorrectAnswer { get { return 25164150;}}
        public override Int64 Solve(){
            Int64 max = 100;
            Int64 triangle = max.NthTriangularNumber();
            Int64 left = triangle * triangle;
            var right = 0;
            for (int i = 1; i <= max; i++)
            {
                right = right + i*i;
            }               
            
            return left-right;
        }
        
        public override void Test(){
            Assert.AreEqual(3L.NthTriangularNumber(), 6);
            Assert.AreEqual(4L.NthTriangularNumber(), 10);
            Assert.AreEqual(5L.NthTriangularNumber(), 15);
            Assert.AreEqual(6L.NthTriangularNumber(), 21);
        }
    }
}