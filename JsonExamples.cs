using ConsoleProjectLearing.Models;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace ConsoleProjectLearing
{
    internal class JsonExamples
    {
        public void JsonDemo()
        {
            // Creating an object of Person
            PersonModel person = new PersonModel
            {
                Id = 1,
                Name = "John Doe",
                Age = 30,
                Hobbies = new List<string> { "Reading", "Cycling", "Gaming" }
            };

            // Serialize object to JSON
            string jsonString = JsonSerializer.Serialize(person, new JsonSerializerOptions { WriteIndented = true });
            string jsonString1 = JsonSerializer.Serialize(person);
            Console.WriteLine("Serialized JSON:");
            Console.WriteLine(jsonString);
            Console.WriteLine("Serialized JSON 1:");
            Console.WriteLine(jsonString1);


            // Save JSON to file
            string filePath = @"C:\Users\Dell\Desktop\Interview\person.json";
            //File.WriteAllText(filePath, jsonString);

            // Read JSON from file
            string readJson = File.ReadAllText(filePath);
            Console.WriteLine("\nRead JSON from file:");
            Console.WriteLine(readJson);

            // Deserialize JSON back to object
            PersonModel deserializedPerson = JsonSerializer.Deserialize<PersonModel>(readJson);
            Console.WriteLine("\nDeserialized Object:");
            Console.WriteLine($"Id: {deserializedPerson.Id}, Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            var Demo = "";
            //// Modify JSON data
            //deserializedPerson.Age = 35;
            //string modifiedJson = JsonSerializer.Serialize(deserializedPerson, new JsonSerializerOptions { WriteIndented = true });
            //Console.WriteLine("\nModified JSON:");
            //Console.WriteLine(modifiedJson);



        }

        public void JsonTest()
        {
            // Create a JObject manually
            JObject person1 = new JObject
        {
            { "Name", "John Doe" },
            { "Age", 30 },
            { "Email", "john.doe@example.com" },
            { "Roles", new JArray("Admin", "Manager") }  // Array inside JSON
        };
            Console.WriteLine("Name of person1 is :" + person1["Name"]);
            Console.WriteLine("Age of person1 is :" + person1["Age"]);
            Console.WriteLine("Email of person1 is :" + person1["Email"]);
            // Convert to JSON string
            string json = person1.ToString();
            Console.WriteLine("Name in json" + json[2]);
            Console.WriteLine(json);



        }

    }
}
