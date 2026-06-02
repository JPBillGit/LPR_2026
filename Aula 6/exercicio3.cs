using System;

class Program
{
    static void Main()
    {
        // Variaveis dos herois
        string h1_nome = "", h1_poder = ""; int h1_pontos = 0;
        string h2_nome = "", h2_poder = ""; int h2_pontos = 0;
        string h3_nome = "", h3_poder = ""; int h3_pontos = 0;
        string h4_nome = "", h4_poder = ""; int h4_pontos = 0;
        string h5_nome = "", h5_poder = ""; int h5_pontos = 0;

        // Variaveis de selecao
        int vaga1 = 0, vaga2 = 0, vaga3 = 0;
        int totalP = 0;
        int opcao = 0;

        // Loop do menu
        do
        {
            menuPrincipal();
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        if (totalP < 5)
                        {
                            totalP++;
                            cadastrarHeroi(totalP,
                                ref h1_nome, ref h1_poder, ref h1_pontos,
                                ref h2_nome, ref h2_poder, ref h2_pontos,
                                ref h3_nome, ref h3_poder, ref h3_pontos,
                                ref h4_nome, ref h4_poder, ref h4_pontos,
                                ref h5_nome, ref h5_poder, ref h5_pontos);
                        }
                        else
                        {
                            Console.WriteLine("\n Limite atingido de herois!");
                        }
                        break;

                    case 2:
                        if (totalP < 3)
                        {
                            Console.WriteLine("\n Cadastre pelo menos 3 herois antes");
                        }
                        else
                        {
                            selecionarEquipe(totalP,
                                h1_nome, h2_nome, h3_nome, h4_nome, h5_nome,
                                ref vaga1, ref vaga2, ref vaga3);
                        }
                        break;

                    case 3:
                        if (vaga1 == 0 || vaga2 == 0 || vaga3 == 0)
                        {
                            Console.WriteLine("\n Selecione os herois para as vagas necessarias");
                        }
                        else
                        {
                            exibirEquipe(vaga1, vaga2, vaga3,
                                h1_nome, h1_poder, h1_pontos,
                                h2_nome, h2_poder, h2_pontos,
                                h3_nome, h3_poder, h3_pontos,
                                h4_nome, h4_poder, h4_pontos,
                                h5_nome, h5_poder, h5_pontos);
                        }
                        break;

                    case 4:
                        Console.WriteLine("\n Saindo...");
                        break;

                    default:
                        Console.WriteLine("\n Opçao invalida, tente novamente");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\n Por favor, insira um numero valido");
                opcao = 0;
            }
        } while (opcao != 4);
    }

    // Exibe o menu principal
    static void menuPrincipal()
    {
        Console.WriteLine("\n Menu Principal");
        Console.WriteLine("1. Cadastrar Heroi (apenas 5)");
        Console.WriteLine("2. Selecionar Equipe (maximo de 3)");
        Console.WriteLine("3. Exibir equipe e pontos totais");
        Console.WriteLine("4. Sair");
        Console.Write("Escolha uma opcao: ");
    }

    // Realiza o cadastro por referencia
    static void cadastrarHeroi(int id,
        ref string n1, ref string p1, ref int pt1,
        ref string n2, ref string p2, ref int pt2,
        ref string n3, ref string p3, ref int pt3,
        ref string n4, ref string p4, ref int pt4,
        ref string n5, ref string p5, ref int pt5)
    {
        Console.WriteLine($"\n Cadastro do Heroi #{id}");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Pontos de Poder: ");
        string poder = Console.ReadLine();
        Console.Write("Pontos de Habilidade: ");
        int.TryParse(Console.ReadLine(), out int pontos);

        if (id == 1) { n1 = nome; p1 = poder; pt1 = pontos; }
        else if (id == 2) { n2 = nome; p2 = poder; pt2 = pontos; }
        else if (id == 3) { n3 = nome; p3 = poder; pt3 = pontos; }
        else if (id == 4) { n4 = nome; p4 = poder; pt4 = pontos; }
        else if (id == 5) { n5 = nome; p5 = poder; pt5 = pontos; }

        Console.WriteLine("Heroi cadastrado com sucesso");
    }

    // Permite escolher 3 integrantes
    static void selecionarEquipe(int cadastros,
        string n1, string n2, string n3, string n4, string n5,
        ref int v1, ref int v2, ref int v3)
    {
        Console.WriteLine("\nHerois Disponiveis");
        if (cadastros >= 1) Console.WriteLine($"1 - {n1}");
        if (cadastros >= 2) Console.WriteLine($"2 - {n2}");
        if (cadastros >= 3) Console.WriteLine($"3 - {n3}");
        if (cadastros >= 4) Console.WriteLine($"4 - {n4}");
        if (cadastros >= 5) Console.WriteLine($"5 - {n5}");

        Console.Write("\nDigite o número do primeiro heroi para a vaga: ");
        int.TryParse(Console.ReadLine(), out v1);
        Console.Write("Digite o número do segundo heroi para a vaga: ");
        int.TryParse(Console.ReadLine(), out v2);
        Console.Write("Digite o número do terceiro3 heroi para a vaga: ");
        int.TryParse(Console.ReadLine(), out v3);

        Console.WriteLine("Equipe selecionada com sucesso!");
    }

    // Soma a pontuacao dos escolhidos
    static int calcularPontuacao(int v1, int v2, int v3, int pt1, int pt2, int pt3, int pt4, int pt5)
    {
        int total = 0;
        if (v1 == 1) total += pt1; else if (v1 == 2) total += pt2; else if (v1 == 3) total += pt3; else if (v1 == 4) total += pt4; else if (v1 == 5) total += pt5;
        if (v2 == 1) total += pt1; else if (v2 == 2) total += pt2; else if (v2 == 3) total += pt3; else if (v2 == 4) total += pt4; else if (v2 == 5) total += pt5;
        if (v3 == 1) total += pt1; else if (v3 == 2) total += pt2; else if (v3 == 3) total += pt3; else if (v3 == 4) total += pt4; else if (v3 == 5) total += pt5;
        return total;
    }

    // Mostra um heroi especifico da vaga
    static void exibirheroiEspecifico(int id, string n1, string p1, string n2, string p2, string n3, string p3, string n4, string p4, string n5, string p5)
    {
        if (id == 1) Console.WriteLine($"- {n1} (Poder: {p1})");
        else if (id == 2) Console.WriteLine($"- {n2} (Poder: {p2})");
        else if (id == 3) Console.WriteLine($"- {n3} (Poder: {p3})");
        else if (id == 4) Console.WriteLine($"- {n4} (Poder: {p4})");
        else if (id == 5) Console.WriteLine($"- {n5} (Poder: {p5})");
    }

    // Exibe a equipe completa e o total de pontos
    static void exibirEquipe(int v1, int v2, int v3,
        string n1, string p1, int pt1,
        string n2, string p2, int pt2,
        string n3, string p3, int pt3,
        string n4, string p4, int pt4,
        string n5, string p5, int pt5)
    {
        Console.WriteLine("\nIntegrantes da equipe:");
        exibirheroiEspecifico(v1, n1, p1, n2, p2, n3, p3, n4, p4, n5, p5);
        exibirheroiEspecifico(v2, n1, p1, n2, p2, n3, p3, n4, p4, n5, p5);
        exibirheroiEspecifico(v3, n1, p1, n2, p2, n3, p3, n4, p4, n5, p5);

        int pontosTotais = calcularPontuacao(v1, v2, v3, pt1, pt2, pt3, pt4, pt5);
        Console.WriteLine($"Pontuaçao total da equipe: {pontosTotais}");
    }
}
