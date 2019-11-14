using Alura.ListaLeitura.Modelos;
using System.Collections.Generic;

namespace Alura.ListaLeitura.WebApp.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Livro> ParaLer { get; set; }
        public IEnumerable<Livro> Lendo { get; set; }
        public IEnumerable<Livro> Lidos { get; set; }
    }
}
