using Interfaces;

Desarrollador dev_1 = new Desarrollador();
dev_1.Name = "Hector";
dev_1.Tecnologias = new string[] { "C#", "Python"};
string[] tecnologias = dev_1.GetTecnologias();
for (int i = 0; i < tecnologias.Length; i++) {
    Console.WriteLine(tecnologias[i]);
}