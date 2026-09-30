# Projeto WinForms

Aplicação desktop desenvolvida em **C# com Windows Forms**, utilizando **.NET Framework 4.8**.
Backup do banco de dados está em ```backup.dump```

## Requisitos

Para executar o projeto, é necessário ter:

* Windows
* Visual Studio 2022 ou superior
* .NET Framework 4.8
* Componentes/dependências presentes no repositório

## Como executar

### 1. Clonar o repositório

Clone o projeto utilizando Git:

```bash
git clone URL_DO_REPOSITORIO
```

Ou faça o download do projeto pelo GitHub.

### 2. Abrir o projeto

Abra o arquivo da solução:

```text
*.sln
```

no **Visual Studio**.

### 3. Restaurar as dependências

No Visual Studio, aguarde o carregamento dos projetos e a restauração dos pacotes NuGet.

Caso necessário:

**Tools → NuGet Package Manager → Manage NuGet Packages for Solution**

e restaure os pacotes.

### 4. Executar

Defina o projeto principal como **Startup Project**:

1. Clique com o botão direito no projeto principal.
2. Selecione **Set as Startup Project**.
3. Pressione **F5** ou clique em **Start**.

A aplicação será iniciada.

## Executável

O arquivo executavel pronto para execução em WINDOWS poderá ser encontrado na pasta:

```text
Release\
```

Execute o arquivo:

```text
TrabalhoBan.exe
```

## Estrutura

```text
Projeto/
├── Projeto.sln
├── Projeto/
│   ├── Formulários
│   ├── Classes
│   ├── Recursos
│   └── ...
└── README.md
```

## Tecnologias

* C#
* Windows Forms
* .NET Framework 4.8
* Visual Studio
* NuGet

## Observação

O projeto utiliza o Supabase como plataforma para hospedar um banco PostgreSQL de forma remota. 

---
