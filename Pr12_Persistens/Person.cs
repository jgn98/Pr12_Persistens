using System.Globalization;
using System.Security.Cryptography;

namespace Pr12_Persistens;

public class Person
{
    private string name;
    public string Name
    {
        get
        {
        return name;
        }
        set
        {
            name = value;
            if (Name.Length == 0)
            {
                throw new System.Exception("Name cannot be empty");
            }
        }
        
    }
    private DateTime birthday;

    public DateTime BirthDate
    {
        get
        {
            return birthday;
        }

        set
        {
            birthday = value;
            if (BirthDate.Year < 1900)
            {
                throw new System.Exception("Birth date cannot be before 1900");
            }
        }
    }

    private double height;
    public double Height
    {
        get
        {
            return height;
        }
        set
        {
            height = value;
            if (Height < 0)
            {
                throw new System.Exception("Height cannot be negative");
            }
        }
    }
    
    public bool IsMarried { get; set; }
    private int noOfChildren;

    public int NoOfChildren
    {
        get
        {
            return noOfChildren;
        }
        set
        {
            noOfChildren = value;
            if (NoOfChildren < 0)
            {
                throw new System.Exception("Number of children cannot be negative");
            }
        }
    }
    
    public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
    {
        Name = name;
        BirthDate = birthDate;
        Height = height;
        IsMarried = isMarried;
        NoOfChildren = noOfChildren;
   
    }
    public Person(string name, DateTime birthDate, double height, bool isMarried)
    {
        Name = name;
        BirthDate = birthDate;
        Height = height;
        IsMarried = isMarried;
       
    }

    public string MakeTitle()
    {
        return $"{Name};{BirthDate.ToString("dd-MM-yyyy HH:mm:ss",System.Globalization.CultureInfo.InvariantCulture)};{Height};{IsMarried};{NoOfChildren}";
    }
    





}