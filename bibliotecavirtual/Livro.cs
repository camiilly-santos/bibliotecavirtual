using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecavirtual
{
    internal class Livro
    {
        public int CodLivro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Data_lancamento { get; set; }
        public string Pais_origem { get; set; }
        public string Descricao { get; set; }

        public Livro(int codLivro, string Titulo,
            string Autor, string Data_lancamento, string Pais_origem, string Descricao) : this( Titulo, Autor, Data_lancamento, Pais_origem, Descricao)
        {
            CodLivro = codLivro;
        }

        public Livro(string Titulo, string Autor, string Data_lancamento, string Pais_origem, string Descricao )
        {
            Titulo = Titulo;
            Autor = Autor;
            Data_lancamento = Data_lancamento;
            Pais_origem = Pais_origem;
            Descricao = Descricao;
        }
    }
}

