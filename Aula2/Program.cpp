#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    int cod1, qte1, cod2, qte2;
    double valor1, valor2, total;

    cin >> cod1 >> qte1 >> valor1;
    cin >> cod2 >> qte2 >> valor2;

    total = (qte1 * valor1) + (qte2 * valor2);

    cout << fixed << setprecision(2);
    cout << "VALOR A PAGAR: R$ " << total << endl;

    return 0; 
}