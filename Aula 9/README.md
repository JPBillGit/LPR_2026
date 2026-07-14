# Cadastro e Análise de População de Cidades

Este é um programa desenvolvido em **C#** que simula um sistema de gerenciamento e análise de dados populacionais de cidades. O projeto foi criado como parte das atividades práticas da **Aula 9**.

O objetivo principal deste código é exercitar o uso da estrutura de dados `Dictionary<TKey, TValue>` (Dicionário), manipulação de coleções, laços de repetição e condicionais em C#.

## Funcionalidades

O programa executa as seguintes etapas de forma interativa pelo console:

1. **Cadastro Dinâmico:** Pergunta ao usuário quantas cidades deseja cadastrar e, em seguida, solicita o nome e a população de cada uma delas, armazenando-as em um `Dictionary<string, int>` (onde a chave é o nome da cidade e o valor é a população).
2. **Cálculo de Média:** Calcula a média populacional de todas as cidades inseridas.
3. **Filtro de População:** Exibe uma lista contendo apenas as cidades que possuem população **acima da média** calculada.
4. **Destaques:** Identifica e exibe separadamente qual é a **cidade mais populosa** e qual é a **menos populosa**.
5. **Remoção de Dados:** Solicita ao usuário um valor limite populacional e remove do dicionário todas as cidades que possuem exatamente aquela população correspondente.
6. **Exibição do Status Final:** Mostra a lista atualizada de cidades que restaram no dicionário após a exclusão.

## Tecnologias e Conceitos Utilizados

*   **Linguagem:** C# (.NET)
*   **Coleções Utilizadas:** 
    *   `Dictionary<string, int>`: Usado para guardar pares de `Cidade (Chave) -> População (Valor)`.
    *   `List<string>`: Auxiliou de forma temporária na remoção segura de itens do dicionário durante o loop.
*   **Manipulação de Loops:** `for` e `foreach`.
*   **Formatação de Saída:** Uso de interpolação de strings (ex: `{media:F2}` para limitar a duas casas decimais).

Exemplo:

Quantas cidades deseja cadastrar? 3

Digite o nome da cidade 1: São Paulo
Digite a população de São Paulo: 12000000

Digite o nome da cidade 2: Santa Rita
Digite a população de Santa Rita: 45000

Digite o nome da cidade 3: Belo Horizonte
Digite a população de Belo Horizonte: 2500000


 Cidades com populacao acima da media (4848333.33):
- São Paulo: 12000000 habitantes

 Cidade mais populosa: São Paulo com 12000000 habitantes.
 Cidade menos populosa: Santa Rita com 45000 habitantes.

Digite um valor Y de populacao para remover do dicionario: 45000

Dicionario Atualizado:
- São Paulo: 12000000 habitantes
- Belo Horizonte: 2500000 habitantes
