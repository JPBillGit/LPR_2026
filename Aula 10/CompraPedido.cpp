#include <iostream>
#include <string>

using namespace std;

class Produto {
public:
    string nome;
    double preco;

    // Construtor do Produto
    Produto(string nome, double preco) {
        this->nome = nome;
        this->preco = preco;
    }
};

class Pedido {
public:
    Produto produto;
    int quantidade;

    // Usando a lista de inicialização 
    Pedido(Produto p, int qtd) : produto(p), quantidade(qtd) {}

    // Método para calcular o preço total da compra
    double calcularTotal() {
        return produto.preco * quantidade;
    }
};

int main() {
   
   
    Produto p1("Teclado Mecanico", 250.00);

    // Criando um pedido associado ao produto com uma quantidade
    Pedido pedido1(p1, 2);

    // Exibindo as informações solicitadas
    cout << "Nome do produto: " << pedido1.produto.nome << endl;
    cout << "Quantidade: " << pedido1.quantidade << endl;
    cout << "Preco total da compra: R$ " << pedido1.calcularTotal() << endl;

    return 0;
}