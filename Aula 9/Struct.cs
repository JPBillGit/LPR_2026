#include <iostream>
#include <vector>
#include <algorithm>
#include <cstdlib>
#include <ctime>

using namespace std;

int main()
{
    srand(time(0));
//preenche o vetor com 100 numeros de 1 a 100
    vector<int> numeros;
    for (int i = 0; i < 100; i++) {
        int numAleatorio = (rand() % 100) + 1;
        numeros.push_back(numAleatorio);
    }
    //ordena crescente
    sort(numeros.begin(), numeros.end());
    cout << "Lista Ordenada" << endl;
    for (int i = 0; i < 100; i++) {
        cout << numeros[i] << " ";
    }
    cout << "\n\n";

    cout << "Numeros repetidos" << endl;
    for (int i = 0; i < numeros.size() - 1; i++)
    {
        if (numeros[i] == numeros[i + 1] && (i == 0 || numeros[i] != numeros[i - 1])) {
            int cont = 0;
            for(int j = 0; j < numeros.size(); j++) {
                if (numeros[j] == numeros[i]) {
                    cont++;
                }
            }
            cout << "O numero " << numeros[i] << " se repete " << cont << " vezes." << endl;
        }
    }
    cout << "\n";

//apaga os numeros pares
    for (int i = 0; i < numeros.size(); )
    {
        if (numeros[i] % 2 == 0)
        {
            numeros.erase(numeros.begin() + i);
        } else
        {
            i++; //só continua se for impar
        }
    }

    cout << "Lista sem par" << endl;
    for(int i = 0; i < numeros.size(); i++)
    {
        cout << numeros[i] << " ";
    }
    cout << endl;

    return 0;
}