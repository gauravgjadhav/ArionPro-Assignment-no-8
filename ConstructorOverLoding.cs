using System;
class Program
{
    private int Length, Height;
    private double Width;
    public Program()
    {
        Console.WriteLine("Default Constructor Invoked");
    }
    public Program(int l, double w) :this()
    {
        Console.WriteLine("Parameterized Constructor in 2nd Constructor");
        this.Length = l;
        this.Width = w;

    }
    public Program(int l, double w, int h) : this(l,w)
    {
        Console.WriteLine("Parameterized Constructor in 3rd Constructor");
        
        this.Height = h;

    }
    public static void Main()
    {
        Program g = new Program(10, 20.5,20); 
        Console.WriteLine("Volume is : {0}", g.Volume());

    }
    public double Volume()
    {
        return (Length * Width * Height);
    }
}
