using System.Collections.Generic;
using Arreglos;

List<string> lst_amigos = new List<string>();

string[] amigos = new string[7];
amigos[0] = "Jazmin";
amigos[1] = "Gabon";

lst_amigos.Add("Jazmin");

for (int i = 0; i < amigos.Length; i++) {
    if (amigos[i] == null)
    {
        Console.WriteLine("Slot no asignado");
    }
    else {
        Console.WriteLine(amigos[i]);
    }
}

for (int i = 0; i < lst_amigos.Count; i++) {
    Console.WriteLine($"Amigo: {lst_amigos[i]}");

}

Person persona_1 = new Person("hector", 32);
Person persona_2 = new Person("Jazmin", 32);
List<Person> lstPersons = new List<Person>();
lstPersons.Add(persona_1);
lstPersons.Add(persona_2);
for (int pid = 0; pid < lstPersons.Count; pid++) {
    Console.WriteLine(lstPersons[pid].ToString());
}


lstPersons.ForEach(person =>  Console.WriteLine(person.ToString()));