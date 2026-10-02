# Calculadora de Descontos - Testes Parametrizados com xUnit

Este repositório contém o projeto `CalculadoraDescontos`, desenvolvido para demonstrar a implementação de regras de negócios em C# (.NET 10) e a validação desses cenários através de testes unitários parametrizados com o framework xUnit[cite: 4, 7].

## 📖 Diferença entre `[Fact]` e `[Theory]` no xUnit

Durante o desenvolvimento de testes unitários com o xUnit, utilizamos dois atributos principais para definir os métodos de teste[cite: 4, 7]:

*   **`[Fact]`**: É utilizado para testes simples e singulares, ou seja, testes que **não recebem parâmetros**. Ele valida apenas um cenário fixo e invariável por vez. Se você precisar testar dados diferentes, terá que criar um novo método `[Fact]` do zero.
*   **`[Theory]`**: É utilizado para testes parametrizados. Ele permite que o mesmo método de teste seja executado múltiplas vezes com conjuntos de dados de entrada diferentes. Para fornecer esses dados, o `[Theory]` trabalha em conjunto com o atributo **`[InlineData(dados...)]`**. Isso evita a repetição de código, permitindo validar diversos cenários (como diferentes idades, valores ou categorias) num único bloco de teste.

## 🛠️ Regras de Negócio Implementadas

A classe `DescontoService` (no projeto `CalculadoraDescontos.App`) implementa três métodos[cite: 5]:
1.  **`ObterCategoriaCliente(int totalCompras)`**: Retorna a categoria "BRONZE", "PRATA" ou "OURO" com base na quantidade de compras.
2.  **`CalcularDescontoPorPercentual(int valorOriginal, int percentualDesconto)`**: Aplica uma porcentagem de desconto sobre um valor e retorna o preço final.
3.  **`EValidoParaCupom(int idade, bool primeiraCompra)`**: Valida a elegibilidade para um cupom de desconto (maioridade ou ser a primeira compra).

Todos os métodos estão cobertos por testes utilizando o atributo `[Theory]` acompanhado de múltiplos `[InlineData]` no projeto `CalculadoraDescontos.Tests`[cite: 6].

## 🚀 Como Executar os Testes

Para rodar a suíte de testes e observar como cada `[InlineData]` é executado como um teste individual, certifique-se de ter o SDK do .NET instalado. Abra o terminal na raiz da solução e execute o seguinte comando[cite: 6, 7]:

```bash
dotnet test
