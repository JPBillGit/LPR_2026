# Aula 08: Variáveis Compostas Heterogêneas (Registros / Structs)

Este diretório contém as soluções dos exercícios obrigatórios propostos na **Aula 08** da disciplina de Linguagem de Programação (LPR) do Curso Técnico em Desenvolvimento de Sistemas - Games (ETE FMC).

A entrega consiste em 3 exercícios resolvidos: **2 em C++ e 1 em C#** (atendendo à regra de utilizar ambas as linguagens).

---

## Exercícios Resolvidos

### 📂 Exercício 2 (C++) — Controle de Estoque
* **Arquivo:** `Exercicio2.cpp`
* **Explicação do Código:**
  * Define uma estrutura `Produto` contendo os campos: `Nome`, `Codigo`, `Preco` e `Quantidade`.
  * Cria um vetor de 3 elements do tipo `Produto` para armazenar os dados inseridos.
  * Solicita ao usuário a inserção de dados para cada produto e exibe o **valor total do estoque** ao final multiplicando o preço pela quantidade.

### 📂 Exercício 3 (C++) — Cadastro de Livros
* **Arquivo:** `Exercicio3.cpp`
* **Explicação do Código:**
  * Define uma estrutura `Livro` com as seguintes propriedades: `Titulo`, `Autor`, `AnoPublicacao`, `NumeroPaginas` e `Preco`.
  * Recebe as informações de 3 livros digitadas pelo usuário.
  * Calcula e apresenta a soma total dos preços e a **média do número de páginas** dos livros.

### 📂 Exercício 4 (C#) — Seleção de Equipe de Heróis (Marvel)
* **Arquivo:** `Exercicio4.cs`
* **Explicação do Código:**
  * Define a struct `Heroi` com as propriedades: `Nome`, `Poder` e `Pontuacao`.
  * Utiliza vetores estáticos de tamanho fixo para armazenar os cadastros (limite de 5 heróis) e a equipe ativa (3 heróis), sem usar listas ou classes.
  * Organizado em funções simples:
    * `cadastrarHeroi()`: Registra dados de um herói.
    * `selecionarEquipe()`: Lista os heróis salvos e permite escolher 3 membros digitando seus índices.
    * `calcularPontuacaoTotal()`: Soma os pontos da equipe.
    * `exibirEquipe()`: Exibe os heróis recrutados e a soma final de pontuação.
    * `menuPrincipal()`: Controla a execução do programa em um loop iterativo até o usuário decidir sair.

