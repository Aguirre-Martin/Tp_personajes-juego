using Tp_personajes;
PersonajeDeFuerza strong = new PersonajeDeFuerza("Thorsten", 40, 30);
Console.WriteLine(strong.CalcularDanio());
Console.WriteLine(strong.Atacar());

PersonajeDeAgilidad agile = new PersonajeDeAgilidad("Pantro", 30, 10, 15);
Console.WriteLine(agile.CalcularDanio());
Console.WriteLine(agile.Atacar());

PersonajeDeMagia wizard = new PersonajeDeMagia("Melchiades", 50, 80);
Console.WriteLine(wizard.CalcularDanio());
Console.WriteLine(wizard.Atacar());

PersonajeDeMagia wizard2 = new PersonajeDeMagia("Xavier", 20, 60, 200);
Console.WriteLine(wizard2.CalcularDanio());
Console.WriteLine(wizard2.Atacar());


Console.WriteLine(agile.MoverseEjeX());


Enemigo enemy = new Enemigo(100, 3);

Console.WriteLine(enemy.MoverseEjeY());
Console.WriteLine(enemy.MoverseEjeX());


List<Personaje> personajes = new List<Personaje>();
personajes.Add(strong);
personajes.Add(agile);
personajes.Add(wizard);
personajes.Add(wizard2);

Turno.Atacarse(personajes);


List<IMoverse> lista = new();

lista.Add(strong);
lista.Add(agile);
lista.Add(wizard);
lista.Add(wizard2);
lista.Add(new Enemigo(100, 3));


foreach (IMoverse item in lista)
{
    Turno.MoverFichas(item);

}


