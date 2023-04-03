using System;

public class MyExtensions
{
    public static bool IsPrime(this int integer)
    {
        // something 
        return true;
        // to call in other class int _number=123; _number.IsPrime;
    }
}
/*
   public static bool MethodName(this (type of class to extend) _dataName)
    {
        
        return true;
    }
 */