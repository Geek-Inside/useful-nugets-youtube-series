using System.Text.Json;

var person = new Person("Valera", "Maslennikov");
var personJson = JsonSerializer.Serialize(person);

Console.WriteLine(personJson);

var personFromJson = JsonSerializer.Deserialize<Person>(personJson);
Console.WriteLine($"{personFromJson!.Name} {personFromJson.Surname}");

public record Person(string Name, string Surname);