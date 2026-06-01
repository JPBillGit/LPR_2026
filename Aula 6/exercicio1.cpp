#include <iostream>

int reverterNumero(int numero) {
    int numeroReverso = 0;
    
    while (numero > 0) {
        int ultimoDigito = numero % 10;                 
        numeroReverso = (numeroReverso * 10) + ultimoDigito; 
        numero /= 10;                                    
    }
    
    return numeroReverso;
}

int main() {
    
    int entrada = 1234;
    int saida = reverterNumero(entrada);
    
    std::cout << "ENTRADA: " << entrada << std::endl;
    std::cout << "SAIDA: " << saida << std::endl;
    
    return 0;
}