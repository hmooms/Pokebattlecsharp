using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebattle.Classes.GameLogic
{
    class Pokebag
    {
        // list of pokemon in pokebag
        public List<Pokemon> pokemonList = new List<Pokemon>();
        // const of max pokemon
        public const int MaxPokemonInList = 10;


        // add pokemon to list
        // check if pokebag is not full
        // if not full add pokemon and say pokemon has been added to your pokebag
        // else say Your Pokebag is full, you first have to remove one
        public string AddPokemonToPokebag(Pokemon pokemon)
        {
            if (pokemonList.Count < MaxPokemonInList)
            {
                pokemonList.Add(pokemon);
                return pokemon.name + " has been added to your pokebag!\r\n";
            }
            else
            {
                return "Your Pokebag is full, you first have to remove one.\r\n";
            }
        }

        // Get the names of all the pokemon in the pokebag
        // check if pokebag is not empty
        // if not empty return all the names 
        // if empty say Your pokebag is empty
        public string GetAllNamesFromPokebag()
        {
            string text = "";
            if (pokemonList != null)
            {
                foreach (Pokemon pokemon in pokemonList)
                {
                    text += pokemon.name + "\r\n";
                }
                return text + "are in your pokebag.\r\n";
            }
            else
            {
                return "Your pokebag is empty.\r\n";
            }

        }


        // remove one pokemon from list
        // check if list isnt empty
        // if the list isnt empty loop through the list
        // check if the pokemon name equals the name given
        // if equal remove and return pokemon has been removed from your pokebag
        // if the pokemon is not in the list return pokemon was not in your pokebag please check if you wrote the name correctly
        // if the list was empty say Your pokebag is empty.

        public string RemoveOnePokemonFromPokebag(String name)
        {
            if (pokemonList != null)
            {
                foreach (Pokemon pokemon in pokemonList)
                {
                    // making it to lower case so that the name is no longer case sensitive.
                    if (pokemon.name.ToLower() == name.ToLower())
                    {
                        pokemonList.Remove(pokemon);
                        return pokemon.name + " has been removed from your pokebag!\r\n";
                    }
                }

                // in case the pokemon wasnt in the pokebag
                return name + " was not in your pokebag please check if you wrote the name correctly.\r\n";
            }
            else
            {
                return "Your pokebag is empty.\r\n";
            }
        }


        // remove all pokemon from list
        // check if list isn't empty
        // if it isn't empty clear it and say All your pokemon have been removed from your pokebag
        // if it is empty say Your bag is already empty
        public string RemoveAllPokemonFromList()
        {
            if (pokemonList != null)
            {
                pokemonList.Clear();
                return "All your pokemon have been removed from your pokebag.\r\n";
            }
            else
            {
                return "Your bag is already empty.\r\n";
            }
        }

    }
}
