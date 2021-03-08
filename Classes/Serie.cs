using System;
namespace DIO.Catalogo
{
    public class Serie : EntidadeBase
    {
        private int QtdEpsodios { get; set; }


        public Serie(int id, Genero genero, string titulo, string descricao, int ano, int qtdEpsodios)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.QtdEpsodios = qtdEpsodios;
            this.Excluido = false;

        }

        public override string ToString()
        {

            string retorno = "";
            retorno += string.Format("-------Catálogo de Séries-------{0}", Environment.NewLine);
            retorno += string.Format("Gênero: {0} {1}", this.Genero, Environment.NewLine);
            retorno += string.Format("Titulo: {0} {1}", this.Titulo, Environment.NewLine);
            retorno += string.Format("Descrição: {0} {1}", this.Descricao, Environment.NewLine);
            retorno += string.Format("Ano: {0} {1}", this.Ano, Environment.NewLine);
            retorno += string.Format("Epsódios: {0} {1}", this.QtdEpsodios, Environment.NewLine);
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






