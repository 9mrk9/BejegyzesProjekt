using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Bejegyzes
    {
        string szerzo;
        string tartalom;
        int likeok;
        DateTime letrejott;
        DateTime szerkesztve;

        public Bejegyzes(string szerzo, string tartalom)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.likeok = 0;
            this.letrejott = DateTime.Now;
            this.szerkesztve = this.letrejott;
        }

        public string Szerzo { get => szerzo; }
        public string Tartalom {get => tartalom; set
            {
                tartalom = value;
                szerkesztve = DateTime.Now;
            }
        } 
        public int Likeok { get => likeok; }
        public DateTime Letrejott { get => letrejott; }
        public DateTime Szerkesztve { get => szerkesztve; }

        public void Like()
        {
            this.likeok++;
        }
        override public string ToString()
        {
            string kiirString = $"{szerzo} - {likeok} - {letrejott}";
            if (szerkesztve != letrejott)
            {
                kiirString += $"\nSzerkesztve: {szerkesztve}";
            }
            kiirString += $"\n{tartalom}\n";
            return kiirString;
        }
    }
}