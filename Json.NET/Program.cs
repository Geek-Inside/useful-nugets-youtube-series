using Newtonsoft.Json;

var person = new Person("Valera", "Maslennikov");
var personJson = JsonConvert.SerializeObject(person);

Console.WriteLine(personJson);

var personFromJson = JsonConvert.DeserializeObject<Person>(personJson);
Console.WriteLine($"{personFromJson!.Name} {personFromJson.Surname}");

public record Person(string Name, string Surname);