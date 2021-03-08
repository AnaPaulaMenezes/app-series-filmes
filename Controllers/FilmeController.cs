using System;
namespace DIO.Catalogo
{
    public class FilmeController
    {

        FilmeRepositorio repositorio = new FilmeRepositorio();

        public void ExcluirFilme()
        {
            Console.Write("Digite o id do Filme: ");

            int indiceFilme = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceFilme);


        }

        public void VisualizarFilme()
        {
            Console.Write("Digite o id do filme: ");

            int indiceFilme = int.Parse(Console.ReadLine());

            Filme Filme = repositorio.RetornaPorId(indiceFilme);

            Console.WriteLine(Filme);


        }

        public void AtualizarFilme()
        {
            Console.Write("Digite o id do filme: ");


            int indiceFilme = int.Parse(Console.ReadLine());
            Filme filme = repositorio.RetornaPorId(indiceFilme);

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine(String.Concat("----Atualizar ", filme.Titulo, "----"));

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = 0;
            int.TryParse(Console.ReadLine(), out entradaGenero);
            Util.validaGenero(entradaGenero);

            Console.Write("Digite o Título do filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início do filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do filme: ");
            string entradaDescricao = Console.ReadLine();

            Console.Write("Digite o tempo de duração do filme: ");
            float entradaDuracao = float.Parse(Console.ReadLine());

            Filme atualizaFilme = new Filme(id: indiceFilme,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao,
                                        duracao: entradaDuracao);

            repositorio.Atualiza(indiceFilme, atualizaFilme);




        }

        public void ListarFilmes()
        {
            Console.WriteLine("Lista filmes");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrada.");
                return;
            }

            foreach (var Filme in lista)
            {
                var excluido = Filme.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1} {2}", Filme.retornaId(), Filme.retornaTitulo(), (excluido ? "*Excluído*" : ""));
            }
        }

        public void InserirFilme()
        {
            Console.WriteLine("Inserir novo filme");


            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");

            int entradaGenero = 0;
            int.TryParse(Console.ReadLine(), out entradaGenero);
            Util.validaGenero(entradaGenero);

            Console.Write("Digite o Título do filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início do filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do filme: ");
            string entradaDescricao = Console.ReadLine();

            Console.Write("Digite o tempo de duração do filme: ");
            float entradaDuracao = float.Parse(Console.ReadLine());

            Filme novoFilme = new Filme(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno,
                                        duracao: entradaDuracao);

            repositorio.Insere(novoFilme);


        }


    }

}