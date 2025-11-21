using GenericsConsole;

MyList<string> persons = new MyList<string>(10);
persons.Add("Hector");
persons.Add("Jazmin");
persons.Add("Lyanna");

MyList<int> edades = new MyList<int>(10);
Console.WriteLine(edades.GetType());

edades.Add(18);
edades.Add(16);
edades.Add(8);

MyList<Person> lstPersons = new MyList<Person>(10);
lstPersons.Add(new Person("Hector", 1));
lstPersons.Add(new Person("Jazmin", 2));

Console.WriteLine("-------------------");
persons.ShowElements();
Console.WriteLine("-------------------");
edades.ShowElements();
Console.WriteLine("-------------------");
lstPersons.ShowElements();