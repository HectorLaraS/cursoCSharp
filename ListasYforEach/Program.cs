using ListasYforEach;
using System.Collections.Generic;
using System.Text.Json;
using HX = ListasYforEach.HXHelpFunctions;

List<Beer> beers = new List<Beer>() { 
    new Beer("Corona", "Modelo"),
    new Beer("TKT", "Cuauthemoc")
};
beers.Add(new Beer("Delirium", "Tremens"));

beers.ForEach(beer => Console.WriteLine(beer.ToJSON()));

string json = JsonSerializer.Serialize(beers, HX.options);
File.WriteAllText("D:\\Objetos\\calogo_cervezas.json", json);