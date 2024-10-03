namespace Pr12_Persistens;

class Program
{
    static void Main(string[] args)
    {
        /*Person person = new Person("Anders Andersen", new DateTime(1995, 8, 24), 175.9, true, 3);

        DataHandler handler = new DataHandler("Data.txt");
        handler.SavePersons(person);

        Console.Write("Writing Person: ");
        Console.WriteLine(person.MakeTitle());*/
        DataHandler handler = new DataHandler("Data.txt");
        Person[] persons = new Person[]
        {
            new Person("William Jensen", new DateTime(1975, 8, 24), 175.9, false, 2),
            new Person("Alfred Nielsen", new DateTime(1991, 3, 12), 185.0, true, 3),
            new Person("Oskar Hansen", new DateTime(2005, 11, 9), 183.2, true, 1),
            new Person("Emma Pedersen", new DateTime(2013, 9, 25), 113.7, false, 0),
            new Person("Alma Andersen", new DateTime(1982, 1, 5), 169.9, false, 2),
            new Person("Clara Christensen", new DateTime(1999, 7, 13), 165.3, true, 0),
        };

        // #### ACT ####
        handler.SavePersons(persons);
    }
}