# ConsumerViaCep 📍

Aplicação em Console C# (.NET) desenvolvida para consumir a API pública do ViaCEP, realizando a busca de dados de endereço a partir de um CEP informado pelo usuário.

---

## 📌 Funcionalidades

- Consulta de endereços via requisição HTTP assíncrona (`HttpClient`).
- Leitura do CEP fornecido via entrada do terminal.
- Desserialização de JSON para objetos C# utilizando `System.Text.Json` e `[JsonPropertyName]`.
- Exibição tratada dos dados de retorno (Rua, Bairro, Cidade, Estado, etc.).

---

## 🛠️ Tecnologias Utilizadas

- **C# / .NET** (Console Application)
- **HttpClient** para requisições Web
- **System.Text.Json** para serialização/desserialização de dados

---
