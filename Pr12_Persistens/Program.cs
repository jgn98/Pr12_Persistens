namespace Pr12_Persistens;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Anders Andersen", new DateTime(1995, 8, 24), 175.9, true, 3);

        DataHandler handler = new DataHandler("Data.txt");
        handler.SavePerson(person);

        Console.Write("Writing Person: ");
        Console.WriteLine(person.MakeTitle());
    }
}