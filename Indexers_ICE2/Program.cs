namespace Indexers_ICE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Heroes hero = new Heroes("Antman", 30, "Body-dismorphia", "aadvanced tech", "humour", "dad");
            Heroes hero2= new Heroes("Ironman", 40, "Intelligence", "ego", "sarcasm", "billionaire");

            hero[0] = "Antman";
            Console.WriteLine("Name"+ hero[0]);
            Console.WriteLine("Age:"+ hero[1]);
            Console.WriteLine("Super Power:"+ hero[2]);
            Console.WriteLine("Weakness:"+ hero[3]);
            Console.WriteLine("Personality:"+ hero[4]);
            Console.WriteLine("Background:"+ hero[5]);
            
         
            Console.WriteLine("Name:"+ hero["name"]);
            Console.WriteLine("Age:"+ hero["age"]);
            Console.WriteLine("Super Power:"+ hero["superpower"]);
            Console.WriteLine("Weakness:" +hero["weakness"]);
            Console.WriteLine("Personality:" +hero["personality"]);
            Console.WriteLine("Background:" +hero["background"]);

            hero2[0] = "Ironman";
            Console.WriteLine("Name" + hero2[0]);
            Console.WriteLine("Age:" + hero2[1]);
            Console.WriteLine("Super Power:" + hero2[2]);
            Console.WriteLine("Weakness:" + hero2[3]);
            Console.WriteLine("Personality:" + hero2[4]);
            Console.WriteLine("Background:" + hero2[5]);


            Console.WriteLine("Name:" + hero2["name"]);
            Console.WriteLine("Age:" + hero2["age"]);
            Console.WriteLine("Super Power:" + hero2["superpower"]);
            Console.WriteLine("Weakness:" + hero2["weakness"]);
            Console.WriteLine("Personality:" + hero2["personality"]);
            Console.WriteLine("Background:" + hero2["background"]);
        }

    }
}
