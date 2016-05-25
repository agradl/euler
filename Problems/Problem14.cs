using System;
using System.Collections.Generic;
using System.Linq;
using Helpers;

namespace Problems {
    /*
    Longest Collatz sequence
    Problem 14
    The following iterative sequence is defined for the set of positive integers:

    n → n/2 (n is even)
    n → 3n + 1 (n is odd)

    Using the rule above and starting with 13, we generate the following sequence:

    13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1     (10)
    14 → 12 → 6 → 3 → 10 → 5 → 16 → 8 → 4 → 2 → 1  (11)
    15 → 46 → 23 → 70 → 35 → 106 → 53 → 160 → 80 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1 (18)
    It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

    Which starting number, under one million, produces the longest chain?

    NOTE: Once the chain starts the terms are allowed to go above one million.
    */
    public class Problem14 : AProblem {
        private Dictionary<Int64, Int64> Chains = new Dictionary<Int64, Int64>();
        public override Int64? CorrectAnswer { get { return 837799;}}
        public override Int64 Solve(){
            Int64 index = 999999;
            while(index > 1){
                var size = GetCollatzChainSize(index);
                Chains.Add(index, size);    
                
                index--;      
            }
            var max = Chains.Values.Max();
            return Chains.Where(kv => kv.Value == max).First().Key;
        }
        
        public Int64 GetCollatzChainSize(Int64 startingNumber){
            var count = 0;
            Int64 current = startingNumber;
            while (current > 1){
                count++;
                current = NextCollatz(current);
            }  
            return count;
        }
        
        public Int64 NextCollatz(Int64 number){
            if (number % 2 == 0){
                return number / 2;
            } else {
                return 3 * number + 1;
            }
        }
        
        public override void Test(){
            Assert.AreEqual(GetCollatzChainSize(993440), 152);
            Assert.AreEqual(GetCollatzChainSize(992967), 152);
        }
    }
}