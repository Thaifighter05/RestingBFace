using System.Text.Json;
using RestSharp;
using System.IO;
using System.Runtime.InteropServices;

RestClient client = new("https://swapi.py4e.com/api/");
Console.WriteLine("Which Star Wars Character?");

string starWarsNumber = Console.ReadLine();
RestRequest request = new($"people/{starWarsNumber}");

RestResponse response = client.GetAsync(request).Result;

if (response.StatusCode == System.Net.HttpStatusCode.OK)
{
    StarWars SW = JsonSerializer.Deserialize<StarWars>(response.Content);
    Console.WriteLine(SW.name);
}
else
{
    Console.WriteLine("ssss");
}

// File.WriteAllText("StarWars.json", response.Content);
Console.ReadLine();