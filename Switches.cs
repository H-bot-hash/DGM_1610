

//Theoretical exercise to determine enemies magic element type in element type combat system.


Random magictype = new Random();
int magicelement = r.Next(1,5);

switch (magicelement) 
{
  case 1:
    Console.WriteLine("Fire Type Enemy");
    break;
  case 2:
    Console.WriteLine("Water Type Enemy");
    break;
  case 3:
    Console.WriteLine("Earth Type Enemy");
    break;
  case 4:
    Console.WriteLine("Light Type Enemy");
    break;
  case 5:
    Console.WriteLine("Dark Type Enemy");
    break;

}