#include <iostream>
#include <string>

using namespace std;

struct Produto {
    string Nome;
    int Codigo;
    double Preco;
    int Quantidade;
};

int main() {
    Produto produtos[3];
    double valorTotalEstoque = 0;

    for (int i = 0; i < 3; i++) {
        cout << "Produto " << i + 1 << ":" << endl;
        cout << "Nome: ";
        cin >> produtos[i].Nome;
        cout << "Codigo: ";
        cin >> produtos[i].Codigo;
        cout << "Preco: ";
        cin >> produtos[i].Preco;
        cout << "Quantidade: ";
        cin >> produtos[i].Quantidade;
        cout << endl;

        valorTotalEstoque += produtos[i].Preco * produtos[i].Quantidade;
    }

    cout << "Valor total em estoque: " << valorTotalEstoque << endl;

    return 0;
}