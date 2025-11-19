bool areYouHungry = true;
bool youHaveMoney = true;

if (areYouHungry && youHaveMoney)
{
    Console.WriteLine("Vaya a comer");
} else if (areYouHungry && !youHaveMoney){
    Console.WriteLine("No puedes comer, necesitas dinero");
}
else {
    Console.WriteLine("No coma");
}

string[] elementos =  { "Aveo", "Jeep Liberty", "Honda City"};

for (int i = 0; i < elementos.Length; i++) {
    Console.WriteLine(elementos[i]);
}