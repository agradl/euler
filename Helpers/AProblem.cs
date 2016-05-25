using System;

namespace Helpers {
    public abstract class AProblem {
        public virtual void Test(){}
        public abstract Int64 Solve();
        
        public virtual Int64? CorrectAnswer {get { return null; }}
        protected void Answer(object answer){
            Console.WriteLine("The answer to {0} is {1}", this.GetType().Name, answer);
        }
    }
}
