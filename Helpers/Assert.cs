using System;

public static class Assert {
    public static void IsTrue(bool input, String failureMessage = ""){
        if (!input){
            throw new Exception(String.Format("Test failed - {0}", failureMessage));
        }
    }
    public static void IsFalse(bool input, String failureMessage = ""){
        IsTrue(!input, failureMessage);
    }
    
    public static void AreEqual(Int64 actual, Int64 expected){
        if (actual != expected){
            throw new Exception(String.Format("Test failed - expected \"{0}\" but got \"{1}\"", expected, actual));
        }
    }
}