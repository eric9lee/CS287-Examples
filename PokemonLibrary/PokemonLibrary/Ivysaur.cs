using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMath.NET;

namespace PokemonLibrary
{
    public class Ivysaur : Bulbasaur
    {
        public Ivysaur() : base()
        {
            NationalNo = 2;
            Name = "妙蛙草";

            Cp = 500;
            Iv = random.Next(60, 101);
            if (Iv >= 60 && Iv < 70)
                Cp += random.Next(-10, 11);
            else if (Iv >= 70 && Iv < 80)
                Cp += random.Next(10, 21);
            else if (Iv >= 80 && Iv < 90)
                Cp += random.Next(20, 31);
            else
                Cp += random.Next(30, 51);

            MaxHp = 60;
            MaxHp += random.Next(170, 265);
            CurrentHp = MaxHp;

            Height = 0.71f;
            Height += (float)random.NextDouble(-0.1, 1.5);
            Weight = 6.9f;
            Weight += (float)random.NextDouble(-2.5, 2.6);

            PowerUpStardust = 2500;
            PowerUpCandy = 3;
        }
    }
}