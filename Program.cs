public class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public string City { get; set; }

    public virtual void DescribeYourself()
    {
        System.Console.WriteLine($"Age = {Age}");
        System.Console.WriteLine($"Name = {Name}");
        System.Console.WriteLine($"Lastname = {Lastname}");
        System.Console.WriteLine($"City = {City}");
    }

}

public class Student : Person
{
    public string Year { get; set; }

    public override void DescribeYourself()
    {
        base.DescribeYourself();
        System.Console.WriteLine($"Year = {Year}");
    }
}

public class Teacher : Person
{
    public string Position { get; set; }
}