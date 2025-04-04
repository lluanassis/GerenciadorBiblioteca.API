﻿namespace GerenciadorBiblioteca.API.Entities
{
    public class Livro : BaseEntity
    {
        public Livro(string titulo, string autor, string iSBN, int anoPublicacao) :base()
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = iSBN;
            AnoPublicacao = anoPublicacao;
        }

        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public string ISBN { get; private set; }
        public int AnoPublicacao { get; private set; }
    }
}
