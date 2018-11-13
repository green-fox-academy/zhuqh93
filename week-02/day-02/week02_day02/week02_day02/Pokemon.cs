using System;
using System.Collections.Generic;
using System.Text;

namespace week02_day02
{
    class Pokemon
    {
        private String Name = "";
        private String Type = "";
        public String EffectiveAgainst;

        public Pokemon(String name, String type, String effectiveAgainst)
        {
            Name = name;
            Type = type;
            EffectiveAgainst = effectiveAgainst;
        }

        public bool IsEffectiveAgainst(Pokemon anotherPokemon)
        {
            return EffectiveAgainst == anotherPokemon.Type;
        }

        public String counterPokemonIs(List<Pokemon>pokemonList)
        {
            String name = "";

            foreach (Pokemon pokemon in pokemonList)
            {
                if (pokemon.IsEffectiveAgainst(this))
                {
                    name = pokemon.Name;
                }
            }

            return name;
        }
    }
}
