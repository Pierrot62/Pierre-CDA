using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Invaders.Classes
{
    class Invader
    {
        public char Caractere  { get; set; }

        public Invader(char caractere)
        {
            Caractere = caractere;
        }

        public override string ToString()
        {
            return Char.ToString(this.Caractere);
        }
    }


}
