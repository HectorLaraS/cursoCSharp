using statics;

Person persona_1 = new Person();
persona_1.Name = "Hector";
persona_1.Age = 32;
Console.WriteLine(Person.GetCounts());
Person persona_2 = new Person("Jazmin", 32);
Console.WriteLine(Person.GetCounts());

