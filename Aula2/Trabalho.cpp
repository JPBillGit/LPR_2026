#include <iostream>
#include <iomanip> 
using namespace std;

int main() {
    int numeroFuncionario, horasTrabalhadas;
    double valorHora, salario;

    
    cin >> numeroFuncionario;
    cin >> horasTrabalhadas;
    cin >> valorHora;

    
    salario = horasTrabalhadas * valorHora;

    
    cout << "Numero = " << numeroFuncionario << endl;
    cout << fixed << setprecision(2);
    cout << "Salario = R$ " << salario << endl;

    return 0;
}