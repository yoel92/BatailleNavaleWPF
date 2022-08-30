using System;

namespace BatailleNavale
{
    class Navire
    {
        public TypeNavire Type { get; }
        public bool Coule { get => EstCoule(); }

        private readonly Case[] cases;

        public Navire (TypeNavire type, Case[] carres)
        {
            Type = type;
            cases = carres;

            foreach (Case carre in cases)
            {
                carre.Navire = this;
            }
        }

        private bool EstCoule()
        {
            foreach (Case carre in cases)
            {
                if (!carre.Touche) return false;
            }
            return true;
        }
    }
}
