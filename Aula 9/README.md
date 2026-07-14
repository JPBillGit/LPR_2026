# Aula 09: Listas e Dicionários 
Este repositório contém as atividades práticas e exercícios propostos na **Aula 09** da disciplina de **Linguagem de Programação**, do curso Técnico em Desenvolvimento de Sistemas - Games (ETE FMC - Rede Jesuíta de Educação).

##  O que Aprendi

### 1. Vetores vs. Listas (Vetores Dinâmicos)
* **Vetores tradicionais:** Possuem tamanho estático/predeterminado e são de difícil inserção ou remoção de elementos, embora ofereçam acesso imediato por índice.
* **Listas (Vetores Dinâmicos):** Resolvem as limitações dos vetores, oferecendo tamanho variável e facilidade para inserir e remover elementos de forma dinâmica. 
  * *Analogia física:* Enquanto um vetor funciona como um prédio com número fixo de andares, a lista funciona como uma "caça ao tesouro", onde cada nó guarda o dado e aponta para a localização do próximo elemento na memória.

### 2. Dicionários (Mapas)
* São estruturas de dados compostas por pares de **Chave-Valor**.
* Diferente das listas, o acesso à informação é feito por meio de chaves descritivas únicas (semânticas) em vez de índices numéricos, permitindo buscas e recuperação de dados de forma extremamente rápida.

### 3. Inferência de Tipos (`var` e `auto`)
* **C# (`var`):** Permite ao compilador deduzir o tipo da variável no momento da sua inicialização.
* **C++ (`auto`):** Deduz o tipo de dados de forma automática, simplificando bastante a criação de iteradores e loops `for-each`.



##  Implementação em C# e C++

### Comparativo de Métodos aprendidos:

| Operação | Implementação em C# (`List` / `Dictionary`) | Implementação em C++ (`std::list` / `std::map`) |
| :--- | :--- | :--- |
| **Inicializar Lista** | `List<int> numeros = new();` | `list<int> numeros;` |
| **Inserir no fim** | `numeros.Add(valor);` | `numeros.push_back(valor);` |
| **Remover por valor**| `numeros.Remove(valor);` | `numeros.remove(valor);` |
| **Iterar Lista** | `foreach (var item in numeros)` | `for (auto item : numeros)` |
| **Inicializar Dicionário** | `Dictionary<string, int> dict = new();` | `map<string, int> dict;` |
| **Inserir no Dicionário**| `dict.Add(chave, valor);` ou `dict[chave] = valor;` | `dict.insert({chave, valor});` ou `dict[chave] = valor;` |
| **Tamanho / Contagem** | `dict.Count` | `dict.size()` |



##  Exercícios Desenvolvidos
A tarefa consistiu em resolver 8 exercícios de níveis variados, dividindo-os igualmente entre C# e C++ (4 em cada linguagem).

### Nível Iniciante (Opcional)
* **Exercício 1:** Cadastro de notas escolares em uma lista, calculando a maior nota, a menor nota e a média geral.
* **Exercício 5:** Dicionário de jogos e gêneros, permitindo consultar o gênero digitando o nome do jogo.

### Nível Intermediário
* **Exercício 2:** Lista dinâmica para ordenar palavras/nomes por tamanho em múltiplos níveis (linhas).
* **Exercício 3:** Vetor de 100 números aleatórios ordenados de forma crescente, com filtragem de números pares e checagem de duplicatas.
* **Exercício 6:** Dicionário de nomes e idades para identificar pessoas acima da média de idade, a pessoa mais velha/mais nova, e fazer remoções.
* **Exercício 7:** Dicionário de cidades e populações, fazendo filtragens matemáticas, buscas de extremos e remoção de dados.

### Nível Avançado (Opcional)
* **Exercício 4:** Uso de `struct Piloto` (Nome, Equipe, Pontuação) armazenada em uma lista para gerar estatísticas e rankings de campeonatos de corrida.
* **Exercício 8:** Sistema de biblioteca utilizando dicionários indexados por códigos e contendo a `struct Livro`, com funções para empréstimo, busca e relatório estatístico.



##  Identificação
* **Estudante:** João Pedro Silva Otoni
* **Instituição:** ETE FMC (Escola Técnica Eletrônica Francisco Moreira da Costa)
* **Curso:** Técnico em Desenvolvimento de Sistemas - Games
* **Professor:** José Andery
