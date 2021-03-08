using System;
namespace DIO.Catalogo
{
    public class SerieController
    {

        SerieRepositorio repositorio = new SerieRepositorio();

        public void ExcluirSerie()
        {
            Console.Write("Digite o id da série: ");

            int indiceSerie = int.Parse(Console.ReadLine());
            repositorio.Exclui(indiceSerie);

        }

        public void VisualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            Serie serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }

        public void AtualizarSerie()
        {
            Console.Write("Digite o id da série: ");

            int indiceSerie = int.Parse(Console.ReadLine());


            Serie serie = repositorio.RetornaPorId(indiceSerie);

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine(String.Concat("----Atualizar ", serie.Titulo, "----"));

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = 0;
            int.TryParse(Console.ReadLine(), out entradaGenero);

            Util.validaGenero(entradaGenero);

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = 0;
            int.TryParse(Console.ReadLine(), out entradaAno);

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Console.Write("Digite a quantidade de epsódios da Série: ");
            int entradaQtdEpsodios = int.Parse(Console.ReadLine());

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao,
                                        qtdEpsodios: entradaQtdEpsodios);

            repositorio.Atualiza(indiceSerie, atualizaSerie);



        }

        public void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
            }
        }

        public void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");


            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");

            int entradaGenero = 0;
            int.TryParse(Console.ReadLine(), out entradaGenero);
            Util.validaGenero(entradaGenero);

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Console.Write("Digite a quantidade de epsódios da Série: ");
            int entradaQtdEpsodios = int.Parse(Console.ReadLine());

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno,
                                        qtdEpsodios: entradaQtdEpsodios);

            repositorio.Insere(novaSerie);




        }


    }

}