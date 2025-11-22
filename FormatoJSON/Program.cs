using FormatoJSON;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;

string path = "D:\\Objetos\\test.json";

Beer myBeer = new Beer() { 
    Name="Pikantus",
    Brand="Erdinger"
};

//string json = "{\"Name\": \"Pikantus\",\"Brand\":\"Erdinger\"}";
var options = new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
string json = JsonSerializer.Serialize(myBeer, options);
File.WriteAllText("D:\\Objetos\\beer.json", json);

Console.WriteLine(json);

string jsonNewBeer = File.ReadAllText(path);


Beer newBeer = JsonSerializer.Deserialize<Beer>(jsonNewBeer);
Console.WriteLine(newBeer.ToString());

List<Beer> beers = new List<Beer>
{
    new Beer { Name = "Pikantus", Brand = "Erdinger" },
    new Beer { Name = "Stout", Brand = "Guinness" },
    new Beer { Name = "Porter", Brand = "Fuller's" }
};
string beers_json = JsonSerializer.Serialize(beers, options);

File.WriteAllText("D:\\Objetos\\beers.json", beers_json);
