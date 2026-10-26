# Aula 10 - Programação Orientada a Objetos (POO)

Este diretório contém as soluções desenvolvidas para os exercícios da Aula 10 de Linguagem de Programação (ETE FMC), focando na aplicação prática dos pilares da Programação Orientada a Objetos (classes, atributos, métodos, construtores e encapsulamento)

---

##  Descrição dos Códigos

### 1. Retângulo (`Retangulo.cs` / C#) - *Nível Iniciante*
* **Objetivo:** Modelar um objeto retângulo para calcular a sua área e o seu perímetro com base nas medidas de altura e largura fornecidas pelo utilizador
* **Estrutura:**
  * **Atributos:** `Altura` e `Largura` (do tipo `double`
  * **Métodos:** 
    * `CalcArea()`: Retorna o cálculo da área (`Largura * Altura`)
    * `CalcPerimetro()`: Retorna o cálculo do perímetro (`2 * (Largura + Altura)`)

---

### 2. Funcionário (`Funcionarios.cpp` / C++) - *Nível Intermediário*
* **Objetivo:** Gerizar os dados financeiros de um funcionário, calculando o imposto com base em faixas salariais e permitindo atualizações de salário por meio de reajustes percentuais
* **Estrutura:**
  * **Atributos (Privados):** `nome` e `salarioBruto`
  * **Métodos:**
    * Construtor para inicializar o nome e o salário bruto.
    * `calcularImposto()`: Aplica a tabela de impostos (10% para até R$ 2000, 15% para até R$ 3000, e 20% para valores superiores)
    * `calcularSalarioLiquido()`: Subtrai o imposto calculado do salário bruto.
    * `aumentarSalario(porcentagem)`: Atualiza o salário bruto com base numa margem percentual fornecida
    * `mostrarDados()`: Exibe de forma formatada o nome e o salário líquido atualizado

---

### 3. Aluno (`AlunosMatriculados.cs` / C#) - *Nível Intermediário*
* **Objetivo:** Representar um aluno matriculado numa disciplina, controlando as suas notas em duas provas e um trabalho para calcular a média ponderada e a necessidade de exame final
* **Estrutura:**
  * **Atributos (com propriedades Get/Set):** `Matricula`, `Nome`, `NotaProva1`, `NotaProva2` e `NotaTrabalho`
  * **Métodos:**
    * Construtor para atribuir os dados iniciais do estudante.
    * `Media()`: Calcula a média ponderada final (as provas têm peso 2,5 e o trabalho tem peso 2)
    * `Final()`: Verifica se o aluno obteve média inferior a 60, retornando o valor exato de pontos que faltam para atingir a aprovação (ou zero caso já esteja aprovado diretamente)
