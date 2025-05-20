using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca
{
    internal class Prestamo
    {
        public Usuario User { get; set; }
        public Libro Book { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Prestamo(Usuario user, Libro book)
        {
            User = user;
            Book = book;
            LoanDate = DateTime.Now;
            ReturnDate = LoanDate.AddDays(7);
        }
        public string ShowInfo()
        {
            return $"Prestamo: {Book.Title} - Usuario: {User.Name}\n Fecha de devolución: {ReturnDate.ToShortDateString()}";
        }

    }
}
