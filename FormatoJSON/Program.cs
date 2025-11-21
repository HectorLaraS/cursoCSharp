using FormatoJSON;
using System.IO;
using System.Text.Json;

string path = "D:\\Objetos\\test.json";

Beer myBeer = new Beer() { 
    Name="Pikantus",
    Brand="Erdinger"
};

//string json = "{\"Name\": \"Pikantus\",\"Brand\":\"Erdinger\"}";
string json = JsonSerializer.Serialize(myBeer);
Console.WriteLine(json);

string jsonNewBeer = File.ReadAllText(path);


Beer newBeer = JsonSerializer.Deserialize<Beer>(jsonNewBeer);
Console.WriteLine(newBeer.ToString());