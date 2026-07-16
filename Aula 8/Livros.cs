#include <iostream>
#include <string>

using namespace std;

struct Livro {
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    double Preco;
};

int main() {
    Livro livros[3];
    double precoTotal = 0;
    int totalPaginas = 0;

    for (int i = 0; i < 3; i++) {
        cout << "Livro " << i + 1 << ":" << endl;
        cout << "Titulo: ";
        cin >> livros[i].Titulo;
        cout << "Autor: ";
        cin >> livros[i].Autor;
        cout << "Ano de Publicacao: ";
        cin >> livros[i].AnoPublicacao;
        cout << "Numero de Paginas: ";
        cin >> livros[i].NumeroPaginas;
        cout << "Preco: ";
        cin >> livros[i].Preco;
        cout << endl;

        precoTotal += livros[i].Preco;
        totalPaginas += livros[i].NumeroPaginas;
    }

    double mediaPaginas = (double)totalPaginas / 3;

    cout << "Preco total dos livros: " << precoTotal << endl;
    cout << "Media de paginas: " << mediaPaginas << endl;

    return 0;
}