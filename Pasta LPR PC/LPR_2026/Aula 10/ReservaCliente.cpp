#include <iostream>
#include <vector>
#include <string>

class Cliente;

class Reserva {
private:
    int id;
    std::string data;
    Cliente* cliente;

public:
    Reserva(int id, const std::string& data, Cliente* cliente) 
        : id(id), data(data), cliente(cliente) {}

    void exibir() const {
        std::cout << "Reserva ID: " << id << ", Data: " << data << std::endl;
    }
};

class Cliente {
private:
    std::string nome;
    std::vector<Reserva> reservas;

public:
    Cliente(const std::string& nome) : nome(nome) {}

    std::string getNome() const {
        return nome;
    }

    void adicionarReserva(const Reserva& reserva) {
        reservas.push_back(reserva);
    }

    void listarReservas() const {
        std::cout << "Cliente: " << nome << std::endl;
        for (const auto& reserva : reservas) {
            reserva.exibir();
        }
    }
};

int main() {
    Cliente cliente1("Maria");
    
    Reserva reserva1(101, "15/11/2026", &cliente1);
    Reserva reserva2(102, "20/11/2026", &cliente1);

    cliente1.adicionarReserva(reserva1);
    cliente1.adicionarReserva(reserva2);

    cliente1.listarReservas();

    return 0;
}