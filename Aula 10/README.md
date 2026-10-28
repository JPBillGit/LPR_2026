Aula 10 - Programação Orientada a Objetos (POO)
Este diretório contém as soluções desenvolvidas para os exercícios da Aula 10 de Linguagem de Programação (ETE FMC), focando na aplicação prática dos pilares da Programação Orientada a Objetos (classes, atributos, métodos, construtores, encapsulamento, associação, herança e polimorfismo).

## Descrição dos Códigos

1. **Retângulo** (`Retangulo.cs` / C#) - Nível Iniciante
   - **Objetivo**: Modelar um objeto retângulo para calcular a sua área e o seu perímetro com base nas medidas de altura e largura fornecidas pelo utilizador.
   - **Estrutura**:
     - Atributos: Altura e Largura (do tipo `double`).
     - Métodos: `CalcArea()` (retorna o cálculo da área) e `CalcPerimetro()` (retorna o cálculo do perímetro).

2. **Funcionário** (`Funcionarios.cpp` / C++) - Nível Intermediário
   - **Objetivo**: Gerizar os dados financeiros de um funcionário, calculando o imposto com base em faixas salariais e permitindo atualizações de salário por meio de reajustes percentuais.
   - **Estrutura**:
     - Atributos (Privados): `nome` e `salarioBruto`.
     - Métodos: Construtor, `calcularImposto()`, `calcularSalarioLiquido()`, `aumentarSalario(porcentagem)` e `mostrarDados()`.

3. **Aluno** (`AlunosMatriculados.cs` / C#) - Nível Intermediário
   - **Objetivo**: Representar um aluno matriculado numa disciplina, controlando as suas notas em duas provas e um trabalho para calcular a média ponderada e a necessidade de exame final.
   - **Estrutura**:
     - Atributos (com propriedades Get/Set): `Matricula`, `Nome`, `NotaProva1`, `NotaProva2` e `NotaTrabalho`.
     - Métodos: Construtor, `Media()` e `Final()`.

4. **Pedido e Produto** (C++) - Nível Intermediário
   - **Objetivo**: Representar uma relação de composição onde um pedido está associado a um produto comprado, calculando o valor financeiro total da transação.
   - **Estrutura**:
     - Classe `Produto`: Atributos `nome` e `preco`, inicializados via construtor.
     - Classe `Pedido`: Atributos compostos por um objeto `Produto` e um inteiro `quantidade`.
     - Métodos: Construtor com lista de inicialização e `calcularTotal()` para retornar o valor da compra.

5. **Biblioteca e Livro** (C++) - Nível Intermediário
   - **Objetivo**: Gerir uma coleção dinâmica de livros utilizando encapsulamento e agregação de objetos.
   - **Estrutura**:
     - Classe `Livro`: Atributos privados (`titulo`, `autor`, `anoPublicacao`), métodos Getters/Setters e método de exibição de detalhes.
     - Classe `Biblioteca`: Atributo privado contendo uma lista dinâmica (`std::vector<Livro>`).
     - Métodos: `AdicionarLivro()` e `ListarLivros()`.

6. **Sistema de Personagens - Sobrevivente vs Assassino** (C++) - Nível Avançado
   - **Objetivo**: Demonstrar os conceitos de herança, classes base/derivadas, encapsulamento protegido e polimorfismo (`virtual` / `override`) modelando entidades de jogo.
   - **Estrutura**:
     - Classe Base `Personagem`: Atributos protegidos (`nome`, `velocidade`, `saude`) e método virtual `mover()`.
     - Classe Derivada `Sobrevivente`: Herda de `Personagem`, adicionando estados próprios (`estaFerido`, `progressoReparo`) e métodos específicos (`repararGerador()`, `curar()`).
     - Classe Derivada `Assassino`: Herda de `Personagem`, introduzindo atributos como `raioTerror` e métodos como `atacar()` e `usarPoderEspecial()`.
     - Métodos: Sobrescrita do método `mover()` via polimorfismo para comportamentos específicos de cada tipo de personagem.
