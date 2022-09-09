internal class Program
{
  private static void Main(string[] args)
  {
    Console.WriteLine("Please Write Exercise number 1 2 or 3");
    if (Console.ReadLine() == "1")
        Ex1.SplitPrimes(20);
    else if (Console.ReadLine() == "2")
        Ex2.RigthLeftAvarage(20);
    else if (Console.ReadLine() == "3")
        Ex3.SortVowel();
    else
        Console.WriteLine("No operation found.");
  }
}