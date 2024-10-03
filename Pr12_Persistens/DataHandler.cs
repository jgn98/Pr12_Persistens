using System.IO.Pipes;

namespace Pr12_Persistens;

public class DataHandler
{
    private string dataFileName;

    public string DataFileName
    {
        get;
    }

    public DataHandler(string dataFileName)
    {
        DataFileName = dataFileName;
    }

    public void SavePerson(Person person)
    {
        using (StreamWriter sw = new StreamWriter(DataFileName))
        {
            sw.WriteLine(person.MakeTitle());
            sw.Close();
        }
    }

    public Person LoadPerson()
    {
        Person person = new Person("navn",DateTime.Now,0,false,0);
        string line;
        string[] part = new string[5];
        try
        {
            //Pass the file path and file name to the StreamReader constructor
            using StreamReader sr = new StreamReader(DataFileName);
            //Read the first line of text
            line = sr.ReadLine();
            
            part = line.Split(';');
            person.Name = part[0];
            person.BirthDate = DateTime.Parse(part[1]);
            person.Height = double.Parse(part[2]);
            person.IsMarried = bool.Parse(part[3]);
            person.NoOfChildren = int.Parse(part[4]);
            //close the file
            sr.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
      
        return person;
    }

    public void SavePersons(Person[] persons)
    {
        using (StreamWriter sw = new StreamWriter(DataFileName))
    
        {
            for (int i = 0; i < persons.Length; i++)
            {
                string title = persons[i].MakeTitle(); 
                sw.WriteLine(title);
            }
            sw.Close();
        }
    }
    

    public Person[] LoadPersons()
    {
        
        string[] lines = new string[] { };
        string[] part = new string[5];
        Person[] person = null;
        try
        {
            //Pass the file path and file name to the StreamReader constructor
            using (StreamReader sr = new StreamReader(DataFileName))
            {
                lines = sr.ReadToEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                sr.Close();
            }
            person = new Person[lines.Length];
                for (int i = 0; i < lines.Length; i++)
                {
                part = lines[i].Split(';');
                person[i]= new Person(part[0], DateTime.Parse(part[1]), double.Parse(part[2]), bool.Parse(part[3]), int.Parse(part[4]));
                }
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
        return person;
    }
}
