using System;
using Pokebattle.Classes.GameLogic;
using Pokebattle.Classes.Pokemons;

namespace Pokebattle
{
    class Program
    {
        static void Main(string[] args)
        {
            // create my pokebag
            Pokebag myPokebag = new Pokebag();

            // Create Carl the Pikachu, Charmeleon Hendrick the First and Bro the Charmeleon
            Pikachu pikachu = new Pikachu();
            Charmeleon charmeleon = new Charmeleon();
            Charmeleon bro = new Charmeleon();
            Pikachu pikachu2 = new Pikachu();
            
            Console.WriteLine(Pokemon.GetPopulation());
            Console.WriteLine(Pokemon.GetAverageHealth());
                     

            // yeah it all makes sense trust me
            Console.WriteLine(
                pikachu.Attack(pikachu.attacks[0], charmeleon) +
                charmeleon.Attack(charmeleon.attacks[0], pikachu) +
                pikachu2.Attack(pikachu2.attacks[0], charmeleon) +
                charmeleon.Attack(charmeleon.attacks[0], pikachu) +
                pikachu2.Attack(pikachu2.attacks[0], charmeleon)
            );


            Console.WriteLine(Pokemon.GetPopulation());
            Console.WriteLine(Pokemon.GetAverageHealth());

            Console.WriteLine(
                myPokebag.AddPokemonToPokebag(pikachu) +
                myPokebag.AddPokemonToPokebag(charmeleon) +
                myPokebag.AddPokemonToPokebag(bro) +
                myPokebag.GetAllNamesFromPokebag() +
                myPokebag.RemoveOnePokemonFromPokebag("bro") +
                myPokebag.RemoveAllPokemonFromList()
                );
        }
    }
}
