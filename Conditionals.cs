

//Theoretical Fishing minigame functionality based on random chance


Random fishtype = new Random();
int fish = r.Next(1,5);

if (fish == 1)
{
    Console.WriteLine("You caught a Bass!");
}

if (fish == 2)
{
    Console.WriteLine("You caught a Eel?? What's that doing there?");
}

if (fish == 3)
{
    Console.WriteLine("You caught a Salmon!");
}

if (fish == 4)
{
    Console.WriteLine("You caught a Trout!");
}

if (fish == 5)
{
    Console.WriteLine("You didn't catch anything");
}

