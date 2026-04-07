#include <iostream>
using namespace std;

double mediaPares(int quantidade) {
    int numero, contador = 0, soma = 0;
    int i = 0; 

    while (i < quantidade) {
        cout << "Digite o numero: "; 
        cin >> numero;

        if (numero % 2 == 0) {
            soma += numero; 
            contador++;
        }
        i++;
    }
    if (contador == 0) return 0;
    return (double)soma / contador;
}


int somaImparesMultiplos3(int inicio, int fim) {
    int soma = 0;
    for (int i = inicio; i <= fim; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }
    return soma;
}

void treinamentoJedi(double horasPorDia) {
    double horasPorSemana = horasPorDia * 5;
    double totalHoras = 1000.0;
    double semanas = totalHoras / horasPorSemana;
    double dias = semanas * 5;
    double meses = semanas / 4.5;

    cout << "\n RESULTADO \n";
    cout << "Horas por semana: " << horasPorSemana << endl;
    cout << "Dias necessarios: " << dias << endl;
    cout << "Semanas necessarias: " << semanas << endl;
    cout << "Meses necessarios: " << meses << endl;
}

int main() {
    int opcao;

    do {
        cout << "\n===== MENU =====\n";
        cout << "1 - Media de numeros pares (WHILE)\n";
        cout << "2 - Soma impares multiplos de 3 (FOR)\n";
        cout << "3 - Treinamento Jedi\n";
        cout << "0 - Sair\n";
        cout << "Escolha: ";
        cin >> opcao;

        switch (opcao) {
            case 1: {
                int qtd;
                cout << "Quantidade de numeros: ";
                cin >> qtd;
                double media = mediaPares(qtd);
                if (media == 0)
                    cout << "Nenhum numero par foi digitado.\n";
                else
                    cout << "Media dos pares = " << media << endl;
                break;
            }
            case 2: {
                int resultado = somaImparesMultiplos3(50, 500);
                cout << "Soma (50 a 500) = " << resultado << endl;
                break;
            }
            case 3: {
                double horas;
                cout << "Horas de treino por dia: ";
                cin >> horas;
                treinamentoJedi(horas);
                break;
            }
            case 0:
                cout << "Encerrando...\n";
                break;
            default:
                cout << "Opcao invalida!\n";
        }
    } while (opcao != 0);

    return 0;
}