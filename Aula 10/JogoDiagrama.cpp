#include <iostream>
#include <string>
#include <vector>

// Classe Base
class Personagem {
protected:
    std::string nome;
    float velocidade;
    int saude;

public:
    Personagem(std::string nome, float velocidade, int saude)
        : nome(nome), velocidade(velocidade), saude(saude) {}

    virtual ~Personagem() {}

    virtual void mover() {
        std::cout << nome << " está se movendo a uma velocidade de " << velocidade << " m/s.\n";
    }

    std::string getNome() const { return nome; }
};

// Classe Sobrevivente
class Sobrevivente : public Personagem {
private:
    bool estaFerido;
    float progressoReparo;

public:
    Sobrevivente(std::string nome, float velocidade)
        : Personagem(nome, velocidade, 100), estaFerido(false), progressoReparo(0.0f) {}

    void repararGerador() {
        progressoReparo += 25.0f;
        std::cout << nome << " (Sobrevivente) reparou o gerador. Progresso atual: " << progressoReparo << "%\n";
    }

    void curar() {
        estaFerido = false;
        std::cout << nome << " foi curado e está saudável.\n";
    }

    void mover() override {
        std::cout << "O sobrevivente " << nome << " corre agilmente para escapar.\n";
    }
};

// Classe Assassino
class Assassino : public Personagem {
private:
    float raioTerror;
    bool estaEmFuria;

public:
    Assassino(std::string nome, float velocidade, float raioTerror)
        : Personagem(nome, velocidade, 100), raioTerror(raioTerror), estaEmFuria(false) {}

    void atacar(Sobrevivente& alvo) {
        std::cout << "O assassino " << nome << " desferiu um golpe contra o sobrevivente!\n";
    }

    void usarPoderEspecial() {
        std::cout << nome << " ativou sua habilidade especial de perseguição!\n";
    }

    void mover() override {
        std::cout << "O assassino " << nome << " patrulha a área implacavelmente.\n";
    }
};

int main() {
    // Instanciando objetos de teste
    Sobrevivente billoverbeck("William Bill Overbeck", 4.0f);
    Assassino trapper("DeathSlinger", 4.6f, 32.0f);

    billoverbeck.mover();
    trapper.mover();

    billoverbeck.repararGerador();
    trapper.atacar(billoverbeck);

    return 0;
}