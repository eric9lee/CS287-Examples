using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public abstract class Pokemon
    {
        public int NationalNo { get; set; }
        public string Name { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public int CurrentHp { get; set; }
        public int MaxHp { get; set; }
        public int PowerUpStardust { get; set; }
        public int PowerUpCandy { get; set; }
        protected int Iv { get; set; }
        public int Cp { get; set; }
        protected static Random random;

        public Pokemon()
        {
            if (Pokemon.random == null)
                Pokemon.random = new Random();
        }

        public override string ToString()
        {
            return string.Format("National No: {0}, Name: {1}, HP: {2}/{3}, Height: {4}, Weight: {5}, Stardust: {6}, Candy: {7}"
                , NationalNo
                , Name
                , CurrentHp
                , MaxHp
                , Height
                , Weight
                , PowerUpStardust
                , PowerUpCandy);
        }
    }
}