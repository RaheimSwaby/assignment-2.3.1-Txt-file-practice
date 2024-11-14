using System.Net.Cache;

namespace Notepad_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Demos\code1.txt"; ;
            
           // File.ReadAllLines(filepath);

           // List <string> lines = File.ReadAllLines(filepath).ToList();
           // foreach (string line in lines)
            //{
                //Console.WriteLine(line);
           // }

           // lines.Add("Raheim,22,Fort liberty");

            //File.WriteAllLines(filepath, lines);

            List<Me>  people = new List<Me>();
            List <string> lines = File.ReadAllLines(filepath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(':');  
                Me newPerson = new Me();
                newPerson.Address = entries[0];
                newPerson.FirstName = entries[1];
                newPerson.Age = entries[2];
                people.Add(newPerson);
            }
            Console.WriteLine("Read from text file");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Age} {person.Address}{person.FirstName}");
            }

            people.Add(new Me { FirstName = " First Name: Raheim", Age = "Age: 22", Address = "address:Fort Liberty" });

            List<string> output = new List<string>();
            foreach (var person in people) 
            {
                output.Add(person.FirstName);
                output.Add(person.Age);
                 output.Add(person.Address);
                
            }
            Console.WriteLine("Writing to text file");
            File.WriteAllLines(filepath, output);
            Console.WriteLine("All information stored");

            Console.ReadLine();
        }
    }
}
