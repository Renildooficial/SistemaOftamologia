<div align="center">

  <img src="https://capsule-render.vercel.app/api?type=waving&color=005C84&height=200&section=header&text=👁️%20Visão%20Prime&fontSize=42&fontColor=ffffff&fontAlignY=35" width="100%" alt="Visão Prime"/>

  <p>
    <b>Sistema de Gestão de Oftalmologia para Óticas e Clínicas Oftalmológicas</b>
  </p>

  <p>
    Aplicação desktop desenvolvida em Visual Basic .NET e MySQL
  </p>

  <p>
    <a href="#-sobre-o-projeto">Sobre</a> •
    <a href="#-funcionalidades">Funcionalidades</a> •
    <a href="#-tecnologias">Tecnologias</a> •
    <a href="#-arquitetura">Arquitetura</a> •
    <a href="#-como-executar">Executar</a> •
    <a href="#-autores">Autores</a>
  </p>

  <p>
    <img src="https://img.shields.io/badge/Visual%20Basic%20.NET-512BD4?style=for-the-badge&logo=.net&logoColor=white"/>
    <img src="https://img.shields.io/badge/Windows%20Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white"/>
    <img src="https://img.shields.io/badge/MySQL-005C84?style=for-the-badge&logo=mysql&logoColor=white"/>
    <img src="https://img.shields.io/badge/Architecture-MVC-8A2BE2?style=for-the-badge"/>
  </p>

</div>

---

## 📌 Sobre o Projeto

O **Visão Prime – Sistema de Gestão de Oftalmologia** é uma aplicação desktop desenvolvida em **Visual Basic .NET**, utilizando **Windows Forms** e **MySQL**, destinada à gestão integrada de uma ótica e clínica oftalmológica.

O sistema centraliza os principais processos clínicos e comerciais, permitindo gerir **clientes, consultas, receituários, produtos, stock, vendas e utilizadores**.

A solução foi concebida para reduzir processos manuais, minimizar erros, melhorar o controlo das operações e facilitar o acesso às informações da clínica/ótica.

---

## ✨ Funcionalidades

### 👤 Gestão de Clientes

* Cadastro de clientes/pacientes.
* Consulta e edição dos dados.
* Gestão das informações de contacto.
* Associação dos clientes às consultas e vendas.

### 🩺 Gestão de Consultas

* Agendamento de consultas.
* Registo de data e hora.
* Associação do médico responsável.
* Definição do tipo de consulta.
* Controlo do estado da consulta.
* Registo de observações.

### 👓 Receituário Oftalmológico

* Registo dos dados refrativos.
* Dados de visão de longe e perto.
* Esférico, cilíndrico e eixo.
* DNP, adição e altura.
* Definição do tipo de lente.
* Emissão de receituário digital em PDF.

### 📦 Gestão de Produtos e Stock

* Cadastro de óculos, lentes e acessórios.
* Código único dos produtos.
* Marca e modelo.
* Preço de custo e preço de venda.
* Controlo de stock atual.
* Definição de stock mínimo.
* Alertas de stock mínimo.

### 💰 Gestão de Vendas

* Registo de vendas.
* Seleção de produtos.
* Controlo da quantidade disponível.
* Aplicação de descontos.
* Seleção da forma de pagamento.
* Atualização automática do stock.
* Geração de recibo.

### 🔐 Gestão de Utilizadores

* Login e autenticação.
* Criação de utilizadores.
* Gestão de contas.
* Ativação/desativação de utilizadores.
* Controlo de permissões.
* Perfis de **Administrador** e **Utilizador**.
* Alteração e troca de conta.

### 📊 Relatórios e Estatísticas

* Relatórios de vendas.
* Relatórios de stock.
* Relatórios de consultas.
* Informações para apoio à gestão e tomada de decisões.

As funcionalidades principais estão alinhadas com os requisitos funcionais definidos no projeto, incluindo clientes, consultas, receituários, produtos, vendas, utilizadores, relatórios e autenticação.

---

## 🛠️ Tecnologias Utilizadas

| Tecnologia                 | Utilização                             |
| -------------------------- | -------------------------------------- |
| **Visual Basic .NET**      | Linguagem principal de desenvolvimento |
| **.NET**                   | Plataforma de desenvolvimento          |
| **Windows Forms**          | Interface gráfica da aplicação         |
| **MySQL**                  | Base de dados relacional               |
| **MVC**                    | Organização arquitetural do sistema    |
| **Visual Studio**          | Ambiente de desenvolvimento            |
| **UML**                    | Modelação e documentação do sistema    |
| **Diagrams.net (Draw.io)** | Criação dos diagramas do sistema       |

O projeto utiliza Visual Basic .NET, Visual Studio, Windows Forms e MySQL como principais tecnologias de desenvolvimento.

---

## 🏗️ Arquitetura

O sistema segue uma organização baseada no padrão **MVC (Model-View-Controller)**, separando a interface, a lógica de negócio e o acesso aos dados.

```text
                    👤 UTILIZADOR
                         │
                         ▼
              ┌─────────────────────┐
              │        VIEW         │
              │    Windows Forms    │
              └──────────┬──────────┘
                         │
                         ▼
              ┌─────────────────────┐
              │     CONTROLLER      │
              │   Regras e Fluxos   │
              └──────────┬──────────┘
                         │
                         ▼
              ┌─────────────────────┐
              │        MODEL        │
              │ Dados e Negócio     │
              └──────────┬──────────┘
                         │
                         ▼
              ┌─────────────────────┐
              │       MySQL         │
              │     Base de Dados   │
              └─────────────────────┘
```

A utilização do MVC permite maior **modularidade, organização, manutenção e evolução** do sistema.

---

## 📁 Principais Módulos

```text
Visão Prime
│
├── 🔐 Autenticação
│   └── Login e controlo de acesso
│
├── 👤 Clientes
│   └── Cadastro e gestão de pacientes
│
├── 🩺 Consultas
│   └── Agendamento e acompanhamento
│
├── 👓 Receituários
│   └── Dados refrativos e emissão de receita
│
├── 📦 Produtos
│   └── Cadastro e controlo de stock
│
├── 💰 Vendas
│   └── Venda e atualização de stock
│
├── 👥 Utilizadores
│   └── Contas e permissões
│
└── 📊 Relatórios
    └── Vendas, stock e consultas
```

---

## 👥 Perfis de Utilizador

| Perfil                | Principais permissões                                        |
| --------------------- | ------------------------------------------------------------ |
| 🔴 **Administrador**  | Gestão de utilizadores, permissões, produtos e configurações |
| 🔵 **Utilizador**     | Operações permitidas no atendimento, consultas e vendas      |
| 🩺 **Oftalmologista** | Realização de consultas e emissão de receituários            |

Os principais atores e responsabilidades do sistema estão definidos na documentação do projeto.

---

## 🔒 Segurança

O sistema implementa mecanismos básicos de segurança e controlo de acesso, incluindo:

* 🔐 Autenticação através de login.
* 👤 Gestão de utilizadores.
* 🛡️ Controlo de permissões.
* 🔑 Diferenciação entre Administrador e Utilizador.
* 💾 Proteção e persistência dos dados através do MySQL.
* 📋 Controlo de acesso aos módulos do sistema.

O sistema define segurança, autenticação, permissões, tratamento de erros e backups como requisitos não funcionais importantes.

---

## 💻 Requisitos

Para executar o sistema, recomenda-se um ambiente Windows com:

* **Windows**
* **Visual Studio**
* **.NET / Visual Basic .NET**
* **MySQL Server**
* **MySQL Workbench** ou ferramenta equivalente

> A aplicação foi concebida como sistema desktop e pode funcionar sem dependência de uma conexão permanente à Internet.

---

## ⚙️ Como Executar

### 1️⃣ Clonar o projeto

```bash
git clone https://github.com/Renildooficial/SEU-REPOSITORIO.git
```

### 2️⃣ Abrir no Visual Studio

Abra o ficheiro da solução:

```text
VisaoPrime.sln
```

ou abra diretamente a pasta do projeto no **Visual Studio**.

### 3️⃣ Configurar o MySQL

Crie a base de dados utilizada pelo sistema e configure os dados de conexão:

```text
Servidor: localhost
Porta: 3306
Utilizador: root
Palavra-passe: sua_senha
Base de dados: dados
```

> ⚠️ Ajuste o nome da base de dados e as credenciais de acordo com a configuração existente no código-fonte.

### 4️⃣ Executar

No Visual Studio:

```text
Build
   ↓
Build Solution
```

Depois:

```text
Start ▶
```

O sistema abrirá inicialmente no **ecrã de autenticação**.

---

## 🗄️ Principais Entidades

A base de dados contém entidades centrais para os processos clínicos e comerciais:

```text
Cliente
   │
   ├── Consulta
   │      │
   │      └── Receituário
   │
   └── Venda
          │
          └── ItemVenda
                    │
                    └── Produto

Usuario
```

As principais entidades identificadas na documentação são **Cliente, Consulta, Receituario, Produto, Venda, ItemVenda e Usuario**.

---

## 🚀 Melhorias Futuras

Entre as evoluções previstas para futuras versões encontram-se:

* 📅 Agendamento online.
* 📱 Aplicação móvel.
* 💳 Integração com pagamentos eletrónicos.
* 📊 Relatórios avançados com gráficos.
* 🧾 Integração com impressoras térmicas.
* 💰 Módulo financeiro e faturação.
* 🩺 Histórico clínico completo do paciente.

Estas funcionalidades são apresentadas na monografia como possibilidades de expansão futura do sistema.

---

## 👨‍💻 Autor

**Renildo Cândido**

Estudante de Licenciatura em Informática
**Universidade Rovuma — ISTLT, Nacala-Porto**
**2026**

---

## 📄 Projeto Académico

**Visão Prime – Sistema de Gestão de Oftalmologia**
Caso de estudo da **Clínica/Ótica Visão Prime**.

Desenvolvido no âmbito da **Licenciatura em Informática** e da disciplina de **Programação Visual**.

---

<div align="center">

### 👁️ Visão Prime

**Tecnologia para uma gestão oftalmológica mais simples, segura e eficiente.**

<br>

<img src="https://capsule-render.vercel.app/api?type=waving&color=005C84&height=120&section=footer" width="100%" alt="Footer"/>

</div>
