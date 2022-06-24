using System;
class CunstructorChaining
{
    String companyName;
    public CunstructorChaining():this("AurionPro")

    {
        Console.WriteLine("Default Constructor");
    }
    public CunstructorChaining(string companyname)
    {
        Console.WriteLine("Parameterized Constructor");
        this.companyName = companyname;
    }   
    public static void Main(string[] args)
    {
        CunstructorChaining pro=new CunstructorChaining();
        Console.WriteLine(pro.companyName);
    }
}