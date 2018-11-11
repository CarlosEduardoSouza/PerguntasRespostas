using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerguntasRespostas.ViewModel
{
    public class CategoriaViewModel
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }


        public static List<CategoriaViewModel> ListaCategorias()
        {
            var lista = new List<CategoriaViewModel>();

            lista.Add(new CategoriaViewModel { Descricao = "Categoria 1", Titulo = "titulo1" });

            lista.Add(new CategoriaViewModel { Descricao = "Categoria 2", Titulo = "titulo2" });

            return lista;
        }

    }
}
