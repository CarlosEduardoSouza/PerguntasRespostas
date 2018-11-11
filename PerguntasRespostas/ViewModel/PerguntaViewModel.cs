using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerguntasRespostas.ViewModel
{
    public class PerguntaViewModel
    {
        public PerguntaViewModel()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Guid? CategoriaId { get; set; }
        public virtual CategoriaViewModel Categoria { get; set; }
        public virtual ICollection<string> Tags { get; set; }
        public virtual ICollection<RespostasViewModel> Respostas { get; set; }
        public DateTime DataCadastro { get; set; }


        public static List<PerguntaViewModel> ListaPerguntas()
        {
            var lista = new List<PerguntaViewModel>();

            lista.Add(new PerguntaViewModel { Descricao = "perguntas 1", Titulo = "titulo1", Autor = "Autor 1" });

            lista.Add(new PerguntaViewModel { Descricao = "perguntas 2", Titulo = "titulo2", Autor = "Autor 2" });

            return lista;
        }

       
    }
}
