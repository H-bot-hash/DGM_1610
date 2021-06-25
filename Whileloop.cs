
//Theoretical exercise to cycle through different int values, and declare statements upon their cycle

Random num = new Random();
int num = r.Next(1,4);

int i = 0;
while (i < 4) 
{
  Console.WriteLine(i);
  i++;


if (num == 1)
{
    Console.WriteLine("Number 1 has been counted");
}

if (num == 2)
{
    Console.WriteLine("Number 2 has been counted");
}

if (num == 3)
{
    Console.WriteLine("Number 3 has been counted");
}

if (num == 4)
{
    Console.WriteLine("Number 4 has been counted");
}


}

