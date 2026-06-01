# 💻 Laboratório de Programação de Computadores (LPR) - 2026

Repositório destinado ao armazenamento das atividades práticas da disciplina de **Laboratório de Programação de Computadores (Aula 6)**, ministrada pelo **Professor Andery**.

---

## 📅 Aula 6: Estruturas de Repetição e Funções

Este diretório contém as resoluções de três exercícios focados na aplicação prática de estruturas de repetição, modularização de código por meio de funções e controle de variáveis locais em memória.

### 🛠️ O que cada exercício faz:

#### 🔹 Exercício 1: Inversor de Números (Desenvolvido em C++)
* **Nome do arquivo:** `exercicio1.cpp`
* **O que faz:** Realiza uma operação puramente matemática para inverter a ordem de qualquer número inteiro positivo (por exemplo, transformando `1234` em `4321`). 
* **Como funciona:** O algoritmo isola a lógica dentro de uma função que utiliza uma estrutura de repetição (`while`) combinada com operadores aritméticos: o operador de resto (`% 10`) captura o último dígito, e a divisão inteira (`/ 10`) reduz o número original até que ele chegue a zero. O processo é feito de forma nativa, sem converter o número para texto (String).

#### 🔹 Exercício 2: Centralizador com Menu Interativo (Desenvolvido em C++)
* **Nome do arquivo:** `exercicio2.cpp`
* **O que faz:** Foca na organização e modularização de código, agrupando múltiplos algoritmos independentes sob um único controle centralizado.
* **Como funciona:** Três lógicas distintas baseadas em repetição (o inversor do Exercício 1, um calculador de fatorial e um verificador de números primos) foram encapsuladas em funções genéricas. Na função principal (`main`), roda um menu interativo construído com `do-while` e `switch-case`. O usuário escolhe a opção na tela, o programa chama a função correspondente e retorna ao menu de forma contínua.

#### 🔹 Exercício 3: Simulador de Equipe da Marvel (Desenvolvido em C#)
* **Nome do arquivo:** `exercicio3.cs`
* **O que faz:** Simula um sistema de escalação de heróis, servindo como um desafio de lógica rígido: o programa gerencia múltiplos dados na memória **sem utilizar classes, vetores ou listas**.
* **Como funciona:** Como o uso de coleções indexadas foi proibido, o programa cria manualmente conjuntos de variáveis locais para armazenar os dados (Nome, Poder e Pontuação) de até 5 heróis. O fluxo de informações entre as funções de cadastro, seleção e exibição é resolvido através de **passagem de parâmetros por referência (`ref`)**. Ao final, o sistema calcula e exibe a soma matemática exata dos pontos de habilidade dos 3 heróis escolhidos para a equipe.

---
👨‍💻 **Desenvolvedor:** JPBillGit
