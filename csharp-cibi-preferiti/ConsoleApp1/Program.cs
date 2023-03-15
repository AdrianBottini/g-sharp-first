// See https://aka.ms/new-console-template for more information

string[] favouriteFood = { "Frutta", "Pizza", "Pasta", "Sushi" };

for ( int i = 0; i < favouriteFood.Length; i++)
{
    Console.WriteLine( (i) + favouriteFood[i] );
}

Console.WriteLine("in poolposition c'è:" + favouriteFood[3]);

Console.WriteLine("L'ultimo in classifica è:" + favouriteFood[0]);
Console.WriteLine("La via di mezzo è:" + favouriteFood[favouriteFood.Length / 2]);
