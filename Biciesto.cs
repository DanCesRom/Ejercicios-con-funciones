using System;

class Program 
{
  public static void Main (string[] args)
   {
    Console.Clear();
    Console.WriteLine ("Que año quieres revisar si es Biciesto?: ");
    Console.WriteLine ("\n");
    decimal x = Convert.ToDecimal(Console.ReadLine());
    Console.Clear();

    if((x/100)%1 == 0)
    {
      if ((x/400)%1 ==0)
      {
        Console.WriteLine(x + " Es un año Biciesto");
      }
      else
      {
        Console.WriteLine(x + " No es un año Biciesto");
      }
    }
    else
    {
      if ((x/4)%1 == 0)
      {
        Console.WriteLine(x + " Es un año Biciesto");
      }
      else
      {
        Console.WriteLine(x + " No es un año Biciesto");
      }
    }
  }
}