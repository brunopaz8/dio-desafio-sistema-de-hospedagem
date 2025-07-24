# 📚 Sistema de Hospedagem 🏨

Este projeto é um sistema de gerenciamento de hospedagens desenvolvido em C# com .NET. Ele permite o cadastro de suítes, hóspedes e a geração de um resumo da reserva, incluindo o cálculo do valor total da estadia.

---

## 🛠️ Tecnologias Utilizadas
* [.NET ](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) (C#)
* Git/GitHub

---

## 🔧 Funcionalidades
* **Suítes:**
  - Cadastro de tipo, capacidade e valor da diária.
* **Hóspedes:**
  - Cadastro de hóspedes com verificação da capacidade da suíte.
  - Definição do número de dias reservados.
* **Reserva:**
  - Cálculo do valor total da estadia, com desconto de 10% para reservas de 10 dias ou mais.
  - Exibição de um resumo detalhado da reserva.

---

## 📂 Estrutura de Pastas

```
dio-desafio-sistema-de-hospedagem/
├── Models/
│   ├── Pessoa.cs
│   ├── Reserva.cs
│   └── Suite.cs
├── .gitignore
├── Progama.cs
├── SIstema_de_Hospedagem.csproj
├── SIstema_de_Hospedagem.sln
└── README.md
```

---

## 🚀 Como Executar o Projeto:

1️⃣ **Clone o repositório:**

   ```bash
   git clone https://github.com/brunopaz8/dio-desafio-sistema-de-hospedagem
   ```

2️⃣ **Navegue até o diretório do projeto:**

   ```bash
   cd dio-desafio-sistema-de-hospedagem
   ```

3️⃣ **Compile e execute o projeto:**

   ```bash
   dotnet run
   ```

   > Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado em sua máquina.
