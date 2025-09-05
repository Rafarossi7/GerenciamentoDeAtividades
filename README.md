# Gerenciamento de Atividades API

API em ASP.NET Core para gerenciamento de atividades, atualmente com **módulo de usuários implementado**. Projeto em desenvolvimento, com planos de adicionar módulos de atividades, categorias e relatórios.

## Endpoints disponíveis (Usuários)
- `GET /api/usuario` → lista todos os usuários
- `GET /api/usuario/{id}` → busca usuário por Id
- `POST /api/usuario` → cria usuário
- `PUT /api/usuario/{id}` → atualiza usuário
- `DELETE /api/usuario/{id}` → remove usuário

## Observações
- `DataCadastro` é preenchido automaticamente
- `Ativo` indica se o usuário está ativo (`true` por padrão)
- Projeto pronto para testes via Swagger ou Postman
- Projeto acadêmico em desenvolvimento
