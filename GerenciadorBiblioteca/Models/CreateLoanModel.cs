﻿namespace GerenciadorBiblioteca.API.Models
{
    public class CreateLoanModel
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdLivro { get; set; }
        public DateTime DataEmprestimo { get; set; }
    }
}
