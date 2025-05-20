using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca
{
    internal class Libro
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }

        public Libro(string title, string author) 
        {
            Title = title;
            Author = author;
        }

        public string Give()
        {
            if (Available) 
            {
                Available = false;
                return $"{Title} ha sido prestado";    
            } 
            else 
            {
                return $"{Title} no esta disponoble";
            }
        }
        public string Devolver()
        {
            Available = true;
            return $"{Title} ha sido devuelto.";
        }

    }
}
