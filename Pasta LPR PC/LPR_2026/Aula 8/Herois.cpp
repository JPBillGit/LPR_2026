using System;

public struct Heroi {
    public string Nome;
    public string Poder;
    public int Pontuacao;
}

class Program {
    static Heroi[] heroisCadastrados = new Heroi[5];
    static int totalCadastrados = 0;
    static Heroi[] equipeSelecionada = new Heroi[3];
    static int totalEquipe = 0;

    static void Main() {
        menuPrincipal();
    }

    static void menuPrincipal() {
        int opcao = 0;
        do {
            Console.WriteLine("\n--- MENU PRINCIPAL ---");
            Console.WriteLine("1 - Cadastrar Heroi");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opcao: ");
            
            if (int.TryParse(Console.ReadLine(), out opcao)) {
                switch (opcao) {
                    case 1:
                        cadastrarHeroi();
                        break;
                    case 2:
                        selecionarEquipe();
                        break;
                    case 3:
                        exibirEquipe();
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }
            }
        } while (opcao != 4);
    }

    static void cadastrarHeroi() {
        if (totalCadastrados >= 5) {
            Console.WriteLine("Limite de 5 herois cadastrados atingido.");
            return;
        }

        Heroi h;
        Console.Write("Nome do Heroi: ");
        h.Nome = Console.ReadLine();
        Console.Write("Poder: ");
        h.Poder = Console.ReadLine();
        Console.Write("Pontuacao: ");
        h.Pontuacao = int.Parse(Console.ReadLine());

        heroisCadastrados[totalCadastrados] = h;
        totalCadastrados++;
        Console.WriteLine("Heroi cadastrado com sucesso!");
    }

    static void selecionarEquipe() {
        if (totalCadastrados < 3) {
            Console.WriteLine("Cadastre pelo menos 3 herois antes de selecionar a equipe.");
            return;
        }

        Console.WriteLine("\nHerois disponiveis para selecao:");
        for (int i = 0; i < totalCadastrados; i++) {
            Console.WriteLine($"{i} - {heroisCadastrados[i].Nome} (Poder: {heroisCadastrados[i].Poder} | Pontos: {heroisCadastrados[i].Pontuacao})");
        }

        totalEquipe = 0;
        while (totalEquipe < 3) {
            Console.Write($"Selecione o heroi {totalEquipe + 1} (digite o indice): ");
            int indice = int.Parse(Console.ReadLine());

            if (indice >= 0 && indice < totalCadastrados) {
                equipeSelecionada[totalEquipe] = heroisCadastrados[indice];
                totalEquipe++;
            } else {
                Console.WriteLine("Indice invalido, tente novamente.");
            }
        }
        Console.WriteLine("Equipe selecionada com sucesso!");
    }

    static int calcularPontuacaoTotal() {
        int soma = 0;
        for (int i = 0; i < totalEquipe; i++) {
            soma += equipeSelecionada[i].Pontuacao;
        }
        return soma;
    }

    static void exibirEquipe() {
        if (totalEquipe < 3) {
            Console.WriteLine("A equipe ainda nao foi formada.");
            return;
        }

        Console.WriteLine("\n--- SUA EQUIPE ---");
        for (int i = 0; i < totalEquipe; i++) {
            Console.WriteLine($"- {equipeSelecionada[i].Nome} (Poder: {equipeSelecionada[i].Poder})");
        }
        Console.WriteLine($"Pontuacao Total da Equipe: {calcularPontuacaoTotal()}");
    }
}