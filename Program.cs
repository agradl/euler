using System;
using System.Linq;
using System.Reflection;
using Helpers;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Starting with arg {0}", args[0]);
                var matcher = args.Length > 0 ? "Problem" + args[0] : "Problem";
                typeof(Program).GetTypeInfo().Assembly.GetTypes()
                    .Where(type => type.Namespace == "Problems")
                    .Where(type => type.Name.Contains(matcher))
                    .ToList()
                    .ForEach(type => {
                        var problem = (AProblem)Activator.CreateInstance(type);
                        var problemName = problem.GetType().Name;
                        problem.Test();
                        var answer = problem.Solve();
                        if (problem.CorrectAnswer != null){
                            Assert.IsTrue(answer == problem.CorrectAnswer, String.Format("Got {0}, Expected {1} for {2}", answer, problem.CorrectAnswer, problemName));
                        }
                        Console.WriteLine("The answer to {0} is {1}", problemName, answer);
                    });    
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.GetType().FullName);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
                  
        }
    }
}
