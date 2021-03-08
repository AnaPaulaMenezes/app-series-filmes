using System;

namespace DIO.Catalogo
{
    class Program
    {
        static SerieController controllerSerie = new SerieController();
        static FilmeController controllerFilme = new FilmeController();

        static void Main(string[] args)
        {
            string catalogo = ObterCatalogoUsuario();

            string opcaoUsuario = "";
            while (catalogo.ToUpper() != "X")
            {
                try
                {
                    switch (catalogo)
                    {
                        case "1":
                            opcaoUsuario = ObterOpcaoUsuario(1);
                            while (opcaoUsuario.ToUpper() != "X")
                            {
                                switch (opcaoUsuario)
                                {
                                    case "1":
                                        controllerSerie.ListarSeries();
                                        break;
                                    case "2":
                                        controllerSerie.InserirSerie();
                                        break;
                                    case "3":
                                        controllerSerie.AtualizarSerie();
                                        break;
                                    case "4":
                                        controllerSerie.ExcluirSerie();
                                        break;
                                    case "5":
                                        controllerSerie.VisualizarSerie();
                                        break;
                                    case "C":
                                        Console.Clear();
                                        break;

                                    default:
                                        throw new ArgumentOutOfRangeException("Opção inváldia!");
                                }

                                opcaoUsuario = ObterOpcaoUsuario(1);
                            }
                            break;

                        case "2":
                            opcaoUsuario = ObterOpcaoUsuario(2);

                            while (opcaoUsuario.ToUpper() != "X")
                            {
                                switch (opcaoUsuario)
                                {
                                    case "1":
                                        controllerFilme.ListarFilmes();
                                        break;
                                    case "2":
                                        controllerFilme.InserirFilme();
                                        break;
                                    case "3":
                                        controllerFilme.AtualizarFilme();
                                        break;
                                    case "4":
                                        controllerFilme.ExcluirFilme();
                                        break;
                                    case "5":
                                        controllerFilme.VisualizarFilme();
                                        break;
                                    case "C":
                                        Console.Clear();
                                        break;

                                    default:
                                        throw new ArgumentOutOfRangeException();
                                }

                                opcaoUsuario = ObterOpcaoUsuario(2);
                            }
                            break;

                        case "C":
                            Console.Clear();
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }


                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(string.Concat("Erro ao encontrar item: ", ex.Message));

                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Concat("Erro: ", ex.Message));
                }

                finally
                {
                    catalogo = ObterCatalogoUsuario();


                }


            }




            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static string ObterOpcaoUsuario(int catalogo)
        {
            Console.WriteLine();

            if ((Catalogo)catalogo == Catalogo.Filme)
            {
                Console.WriteLine("Bem vindo ao catalogo de filmes:");
                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("1- Listar filmes");
                Console.WriteLine("2- Inserir novo filme");
                Console.WriteLine("3- Atualizar filme");
                Console.WriteLine("4- Excluir filme");
                Console.WriteLine("5- Visualizar filmes");
                Console.WriteLine("C- Limpar Tela");
                Console.WriteLine("X- Voltar");
                Console.WriteLine();


            }
            else
            {
                Console.WriteLine("Bem vindo ao catalogo de séries:");
                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("1- Listar séries");
                Console.WriteLine("2- Inserir nova série");
                Console.WriteLine("3- Atualizar série");
                Console.WriteLine("4- Excluir série");
                Console.WriteLine("5- Visualizar série");
                Console.WriteLine("C- Limpar Tela");
                Console.WriteLine("X- Voltar");
                Console.WriteLine();
            }


            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private static string ObterCatalogoUsuario()
        {

            Console.WriteLine();
            Console.WriteLine("DIO séries e filmes a seu dispor!");
            Console.WriteLine("Escolha um cátalogo para ver ou atualizar:");

            Console.WriteLine("1- Catálogo de séries");
            Console.WriteLine("2- Catálogo de Filmes");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");


            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
