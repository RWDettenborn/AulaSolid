# Processador de Pedidos - Aplicação de Princípios SOLID

Este repositório contém a refatoração de um sistema de processamento de pedidos em C#, desenvolvido como parte de uma atividade acadêmica para demonstrar a aplicação prática dos princípios SOLID em arquitetura de software.

## Sobre o Projeto

O objetivo do trabalho foi analisar uma classe monolítica (`ProcessadorPedido`) que concentrava múltiplas responsabilidades — validação, cálculo de regras de negócio, acesso a banco de dados e envio de notificações — e refatorá-la visando alta coesão e baixo acoplamento.

Os seguintes princípios foram o foco da refatoração:
* **SRP (Single Responsibility Principle):** Separação das responsabilidades. Criou-se classes distintas e isoladas para persistência de dados (`PedidoRepository`) e envio de notificações (`EmailService`).
* **OCP (Open/Closed Principle):** A arquitetura garante que o sistema esteja aberto para extensão. É possível adicionar novos métodos de notificação (ex: `WhatsAppService`) sem necessidade de alterar o código da classe orquestradora.
* **DIP (Dependency Inversion Principle):** O processador principal não depende de implementações concretas, mas sim de interfaces (`IPedidoRepository`, `INotificacaoService`), que são injetadas dinamicamente através do construtor.

## Tecnologias Utilizadas
* C# (.NET Console Application)
* Visual Studio
* Paradigma de Orientação a Objetos

## Estrutura e Versionamento

O histórico de commits deste repositório foi construído em duas etapas lógicas para demonstrar a evolução da arquitetura:
1. **Commit 1:** Contém o cenário original com o código monolítico.
2. **Commit 2:** Contém a versão final refatorada, com leitura de dados interativa e o sistema estruturado em pastas modulares (`/Interfaces`, `/Repositories`, `/Services`).

## Como Executar

1. Realize o clone deste repositório em sua máquina local.
2. Abra o projeto através do **Visual Studio**.
3. Compile e execute a aplicação (atalho `F5`).
4. O terminal interativo solicitará a entrada dos dados do cliente (Nome, Valor do pedido e Contato) para demonstrar a orquestração das dependências e o processamento final.

---
**Autor:** Robert William Dettenborn  
*Trilha de Estudo Autônomo - Análise e Desenvolvimento de Sistemas (ADS) - SESI SENAI (Chapecó/SC)*
