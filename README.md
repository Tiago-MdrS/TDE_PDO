# TDE2 — Pipeline CI com GitHub Actions

**Curso:** Análise e Desenvolvimento de Sistemas — UNIFACEMA  
**UC:** Prática DevOps  
**Professor:** Marcos Gomes da Silva Rocha

---

## Estrutura do Projeto

```
MeuProjeto/
├── Calculadora/
│   ├── Calculadora.cs          ← classe principal (3 métodos)
│   └── Calculadora.csproj
├── Calculadora.Tests/
│   ├── CalculadoraTests.cs     ← testes unitários com xUnit
│   └── Calculadora.Tests.csproj
├── .github/
│   └── workflows/
│       └── main.yml            ← pipeline CI
├── MeuProjeto.sln
└── README.md
```

---

## Como gerar o histórico de Actions (sucesso + erro proposital)

### Passo 1 — Erro proposital (Run #1)

Em `Calculadora.Tests/CalculadoraTests.cs`, altere o teste de divisão:

```csharp
// Troque isto:
Assert.Equal(5, _calc.Divisao(10, 2));

// Por isto:
Assert.Equal(999, _calc.Divisao(10, 2));  // erro proposital
```

Faça o commit e push → o pipeline vai **falhar** ✗

### Passo 2 — Sucesso (Run #2)

Reverta para o valor correto:

```csharp
Assert.Equal(5, _calc.Divisao(10, 2));  // correto
```

Faça o commit e push → o pipeline vai **passar** ✓

---

## Rodar localmente

```bash
dotnet restore
dotnet build
dotnet test --verbosity normal
```

---

## Configurar bloqueio de merge no GitHub

1. Settings > Branches > Add rule para `main`
2. Ativar **Require status checks to pass before merging**
3. Selecionar o check `build-and-test`
4. Salvar
