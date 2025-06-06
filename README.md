# Design-Pattern-GOF

## Sobre o Projeto

Este projeto implementa uma **Calculadora de Impostos** utilizando o padrão de projeto **Strategy**, um dos padrões de design descritos no livro *Design Patterns: Elements of Reusable Object-Oriented Software* (GOF - Gang of Four). O padrão Strategy é utilizado para encapsular diferentes algoritmos dentro de classes separadas, permitindo que eles sejam intercambiáveis de forma flexível.

## Padrão de Projeto Utilizado: Strategy

O padrão **Strategy** é ideal para situações em que há múltiplas variações de um algoritmo e você deseja evitar condicionais complexas no código. Ele permite que o comportamento de uma classe seja definido em tempo de execução, delegando a lógica para classes específicas.

### Estrutura do Projeto

- **Interface `TipoImposto`**: Define o contrato para os diferentes tipos de impostos. Cada imposto implementa o método `Calcular(decimal valor)`.
- **Implementações de Impostos**:
  - `ICMS`: Calcula o imposto ICMS (18%).
  - `IPI`: Calcula o imposto IPI (10%).
  - `PIS_COFINS`: Calcula o imposto PIS/COFINS (9%).
- **Classe `CalculadoraDeImposto`**: Recebe uma implementação de `TipoImposto` e o valor base para cálculo. Utiliza o método `Calcular` da implementação fornecida para calcular o imposto.
- **Classe `Helper`**: Auxilia na seleção do tipo de imposto com base na entrada do usuário.
- **Classe `Program`**: Contém o ponto de entrada do programa, onde o usuário interage com a calculadora.

### Diagrama de Classes

```plaintext
+-------------------+
|   TipoImposto     |<----------------+
+-------------------+                 |
| + Calcular(valor) |                 |
+-------------------+                 |
         ^                            |
         |                            |
+-------------------+   +-------------------+
|       ICMS        |   |       IPI         |
+-------------------+   +-------------------+
| + Calcular(valor) |   | + Calcular(valor) |
+-------------------+   +-------------------+
         ^                            ^
         |                            |
         +----------------------------+
         |
+-------------------+
|    PIS_COFINS     |
+-------------------+
| + Calcular(valor) |
+-------------------+

+-------------------------+
|  CalculadoraDeImposto   |
+-------------------------+
| - tipoImposto           |
| - baseCalculo           |
+-------------------------+
| + calcular()            |
+-------------------------+
```

### Como Funciona

1. O usuário informa o valor do produto e o tipo de imposto desejado (ICMS, IPI ou PIS/COFINS).
2. A classe `Helper` seleciona a implementação correta de `TipoImposto` com base na entrada do usuário.
3. A classe `CalculadoraDeImposto` utiliza a implementação selecionada para calcular o imposto.
4. O resultado é exibido ao usuário.

### Como Executar

1. Certifique-se de ter o **.NET SDK 8.0** instalado.
2. Clone este repositório:
    ```bash
    git clone https://github.com/ElitonCamargo/Design-Pattern-GOF.git
    ```
3. Navegue até o diretório do projeto:
    ```bash
    cd Design-Pattern-GOF
    ```
4. Execute o projeto:
    ```bash
    dotnet run
    ```

### Exemplo de Uso

```plaintext
Informe o valor do produto: 1000
Informe o tipo de imposto (ICMS, IPI, PIS_COFINS): ICMS
O valor do imposto é: 180
```

### Benefícios do Padrão Strategy

- **Flexibilidade**: Permite adicionar novos tipos de impostos sem alterar o código existente.
- **Manutenção**: Reduz a complexidade do código, eliminando condicionais extensas.
- **Reutilização**: Cada algoritmo é encapsulado em uma classe separada, facilitando sua reutilização.

### Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

### Licença

Este projeto está licenciado sob a [MIT License](LICENSE).