#include <iostream>

long long inverterNumero(int n) {
    long long reverso = 0;
    while (n != 0) {
        int digito = n % 10;
        reverso = reverso * 10 + digito;
        n /= 10;
    }
    return reverso;
}

int main() {
    int numero = 12345;
    std::cout << "Original: " << numero << std::endl;
    std::cout << "Reverso: " << inverterNumero(numero) << std::endl;
    
    return 0;
}