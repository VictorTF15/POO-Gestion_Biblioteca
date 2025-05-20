using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca
{
    internal class Usuario
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Usuario(string name, string email)
        { 
            Name = name;
            Email = email;
        }
    }
}
