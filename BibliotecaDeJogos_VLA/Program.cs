using System;
using BibliotecaDeJogos_VLA.Classes;
using System.Collections.Generic;

namespace BibliotecaDeJogos_VLA
{
    class Program
    {
        static List<Jogo> listaJogos = new List<Jogo>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("##### - BIBLIOTECA DE JOGOS - #####");
                Console.WriteLine("\n");
                Console.WriteLine("1- Adicionar um Jogo");
                Console.WriteLine("2- Listar os Jogos");
                Console.WriteLine("3- Atualizar um Jogo");
                Console.WriteLine("4- Deletar um Jogo");

                int opcao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(opcao);
                switch (opcao)
                {
                    case 1:
                        listaJogos.Add(AdicionarJogo());
                        break;

                    case 2:
                        Listar();
                        break;

                    case 3:
                        Alterar();
                        break;

                    case 4:
                        Deletar();
                        break;

                    default:
                        Console.WriteLine("\nOpção Inválida");
                        break;
                }
            }
        }

        static private Jogo AdicionarJogo()
        {
            Console.Clear();
            Console.WriteLine("ADICIONAR JOGO\n");
            //Console.ReadLine();

            string nome = "";
            //int ano = 0;
            while (nome.Length == 0)
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
            }
            /*try
            {
                Console.Write("Lançamento: ");
                ano = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.Write("Formato inválido");
                return null;
            }*/
            Console.Write("Lançamento: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gênero: ");
            string genero = Console.ReadLine();
            Console.Write("Max. de Jogadores: ");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.Write("Metacritic: ");
            int metacritic = Convert.ToInt32(Console.ReadLine());

            Jogo jogo = new Jogo(nome, ano, genero, max, metacritic);
            Console.Beep();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadLine();
            Console.Clear();

            return jogo;
        }

        static private void Listar()
        {
            Console.Clear();
            Console.WriteLine("JOGOS ADICIONADOS:\n");

            foreach (Jogo jogo in listaJogos)
            {
                Console.Write("Jogo: ");
                Console.WriteLine(jogo.getTitulo());
                Console.Write("Ano: ");
                Console.WriteLine(jogo.getAno());
                Console.Write("Gênero: ");
                Console.WriteLine(jogo.getGenero());
                Console.Write("Máximo de jogadores: ");
                Console.WriteLine(jogo.getMaxJogadores());
                Console.Write("Meta Critic: ");
                Console.WriteLine(jogo.getMetaCritic());
                Console.WriteLine("-------------");
                Console.WriteLine("");
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadLine();
            Console.Clear();
        }
        static private void Alterar()
        {
            Console.Clear();
            Console.WriteLine("ALTERAR UM JOGO");
            Console.Write("\nDigite o nome do jogo a ser alterado: ");
            string jogoAlterar = Console.ReadLine();

            Console.WriteLine("\nDigite o número do parâmetro a ser alterado:");
            Console.WriteLine("1 - Título");
            Console.WriteLine("2 - Lançamento");
            Console.WriteLine("3 - Gênero");
            Console.WriteLine("4 - Max de Jogadores");
            Console.WriteLine("5 - Metacritic");
            int parametroAlterar = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite a alteração: ");
            string alteracao = Console.ReadLine();


            try
            {
                foreach (Jogo jogo in listaJogos)
                {
                    if (jogoAlterar == jogo.getTitulo())
                    {
                        switch (parametroAlterar)
                        {
                            case 1:
                                jogo.setTitulo(alteracao);
                                break;

                            case 2:
                                jogo.setAno(Int32.Parse(alteracao));
                                break;

                            case 3:
                                jogo.setGenero(alteracao);
                                break;
                            
                            case 4:
                                jogo.setMaxJogadores(Int32.Parse(alteracao));
                                break;
                            
                            case 5:
                                jogo.setMetaCritic(Int32.Parse(alteracao));
                                break;
                            
                            default:
                                Console.WriteLine("\nParâmetro inválido!");
                                break;
                        }
                        Console.WriteLine("\nParâmtro alterado");
                    }
                }
            }
            catch (InvalidOperationException e)
            {

            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadLine();
            Console.Clear();
        }

        static private void Deletar()
        {
            Console.Clear();
            Console.WriteLine("DELETAR UM JOGO");
            Console.Write("\nDigite o nome do jogo a ser deletado: ");
            string jogoDeletar = Console.ReadLine();

            try
            {
                foreach (Jogo jogo in listaJogos)
                {
                    if (jogoDeletar == jogo.getTitulo())
                    {
                        listaJogos.Remove(jogo);
                        Console.WriteLine("\nJogo deletado");
                    }
                }
            }
            catch(InvalidOperationException e)
            {

            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
