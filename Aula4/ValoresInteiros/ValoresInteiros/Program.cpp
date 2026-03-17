#include <iostream>
using namespace std;

int main()
{
    int A, B;
    cin >> A >> B;

    if (A % B == 0 || B % A == 0) {
        cout << "Sao multiplos" << endl;
    } else {
        cout << "Nao sao multiplos" << endl;
    }

    return 0;
}