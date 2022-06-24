using System;
class Program
{
    String name;
    int id;
    Program(string name, int id)
    {
        this.name = name;
        this.id = id;
    }
    public static void Main(string[] args)
    {
        Program pro = new Program("gaurav",1001);
        Console.WriteLine("Student name is " +pro.name+" and id is "+pro.id);
    }
}