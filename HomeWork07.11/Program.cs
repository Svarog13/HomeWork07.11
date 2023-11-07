using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal("Journal A", 2023, 50);
        Journal journal2 = new Journal("Journal B", 2023, 40);

        Console.WriteLine("Journal 1 Employee Count: " + journal1.EmployeeCount);
        Console.WriteLine("Journal 2 Employee Count: " + journal2.EmployeeCount);

        journal1 += 10;  
        journal2 -= 5; 

        Console.WriteLine("Journal 1 Employee Count: " + journal1.EmployeeCount);
        Console.WriteLine("Journal 2 Employee Count: " + journal2.EmployeeCount);

        if (journal1 == journal2)
            Console.WriteLine("Journal 1 and Journal 2 have the same number of employees.");
        else
            Console.WriteLine("Journal 1 and Journal 2 have a different number of employees.");

        if (journal1 > journal2)
            Console.WriteLine("Journal 1 has more employees than Journal 2.");
        else
            Console.WriteLine("Journal 1 has fewer employees than Journal 2.");
    }
}
class Journal
{
    private string name;
    private int year;
    private int employeeCount;

    public Journal(string name, int year, int employeeCount)
    {
        this.name = name;
        this.year = year;
        this.employeeCount = employeeCount;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public int EmployeeCount
    {
        get { return employeeCount; }
        set { employeeCount = value; }
    }

    public static Journal operator +(Journal journal, int increment)
    {
        journal.EmployeeCount += increment;
        return journal;
    }

    public static Journal operator -(Journal journal, int decrement)
    {
        journal.EmployeeCount -= decrement;
        return journal;
    }

    public static bool operator ==(Journal journal1, Journal journal2)
    {
        return journal1.EmployeeCount == journal2.EmployeeCount;
    }

    public static bool operator !=(Journal journal1, Journal journal2)
    {
        return journal1.EmployeeCount != journal2.EmployeeCount;
    }

    public static bool operator <(Journal journal1, Journal journal2)
    {
        return journal1.EmployeeCount < journal2.EmployeeCount;
    }

    public static bool operator >(Journal journal1, Journal journal2)
    {
        return journal1.EmployeeCount > journal2.EmployeeCount;
    }

    public override bool Equals(object obj)
    {
        if (obj is Journal otherJournal)
        {
            return this.EmployeeCount == otherJournal.EmployeeCount;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return EmployeeCount.GetHashCode();
    }
}
