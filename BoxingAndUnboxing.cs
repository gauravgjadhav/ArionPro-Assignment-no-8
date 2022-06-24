using System;
class Program
{
    public static void Main(string[] args)
    {
        int i = 10;
        Object obj = new Object();
        obj = i; // Boxing occurs automatically
        Console.WriteLine(i);
        int j = (int)obj; // Unboxing occurs
        Console.WriteLine(j);
    }
}