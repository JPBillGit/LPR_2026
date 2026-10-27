#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

class Funcionario {
private:
    string nome;
    double salarioBruto; 

public:
    Funcionario(string nome, double salarioBruto) {
        this->nome = nome;
        this->salarioBruto = salarioBruto;
    }

    double calcularImposto() {
        if (salarioBruto <= 2000.0) {
            return salarioBruto * 0.10;
        } else if (salarioBruto <= 3000.0) {
            return salarioBruto * 0.15;
        } else {
            return salarioBruto * 0.20;
        }
    }

    double calcularSalarioLiquido() {
        return salarioBruto - calcularImposto();
    }

    void aumentarSalario(double porcentagem) {
        salarioBruto += salarioBruto * (porcentagem / 100.0);
    }

    void mostrarDados() {
        cout << fixed << setprecision(2);
        cout << "Funcionário: " << nome << ", Salário Líquido: R$ " << calcularSalarioLiquido() << endl;
    }
};

int main() {
    string nome;
    double salarioBruto, porcentagem;

    cout << "Nome do funcionário: ";
    getline(cin, nome);
    cout << "Salário bruto: ";
    cin >> salarioBruto;

    Funcionario func(nome, salarioBruto);

    cout << "\n--- Dados Iniciais ---" << endl;
    func.mostrarDados();

    cout << "\nDigite a porcentagem para aumentar o salário: ";
    cin >> porcentagem;
    func.aumentarSalario(porcentagem);

    cout << "\n--- Dados Atualizados ---" << endl;
    func.mostrarDados();

    return 0;
}