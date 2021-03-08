using System;
namespace DIO.Catalogo
{
    public class Filme : EntidadeBase
    {
        private float Duracao { get; set; }

        public Filme(int id, Genero genero, string titulo, string descricao, int ano, float duracao)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
            this.Duracao = duracao;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += string.Format("-------Catálogo de Filmes-------{0}", Environment.NewLine);
            retorno += string.Format("Titulo: {0} {1}", this.Titulo, Environment.NewLine);
            retorno += string.Format("Gênero: {0} {1}", this.Genero, Environment.NewLine);
            retorno += string.Format("Descrição: {0} {1}", this.Descricao, Environment.NewLine);
            retorno += string.Format("Ano: {0} {1}", this.Ano, Environment.NewLine);
            retorno += string.Format("Tempo de duração: {0} {1}", this.Duracao, Environment.NewLine);
            retorno += string.Format("Excluído: {0} {1}", this.Excluido, Environment.NewLine);

            return retorno;
        }

        public override string retornaTitulo()
        {
            return this.Titulo;
        }

        public override int retornaId()
        {
            return this.Id;
        }

        public override void Excluir()
        {
            this.Excluido = true;
        }

        public override bool retornaExcluido()
        {
            return this.Excluido;
        }
    }
}






