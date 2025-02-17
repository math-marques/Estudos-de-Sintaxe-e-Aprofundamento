# Estudos relacionados à trilha para ser um desenvolvedor .Net Júnior!


- Curiosidade pelo novo, aprimoramento de sintaxes básicas e muuuuuuito exercício prático e erros...
- esse texto é pra eu me lembrar que Deus é misericordioso, tudo é vaidade, ser bom independente da circunstancia


O ano é 2025, mês é janeiro, tenho 22 anos e uma meta de fazer essas coisas pra minha família ter uma realidade minimanete aceitável. Plano de saúde, net, comida, conforto e biblia. 

## Desafio de projeto
API e Entity Framework, da trilha .NET. Atualmente (2025), tenho tido muito contato com Dapper também. A diferença é que no entity, utiliza-se os métodos padronizados do dot net como sintaxe para abertura de conexão com o banco, selects, referenciamento de ooutras classes e suas propriedades/campos. O Dapper faz com que, literalmente, montemos um @$"script/query", e digitemos o script no mesmo formato que seria no banco, independente de qual seja.

## Contexto
Construi uma listagem de exercícios praticos sobre o aprofundamento na sintaxe.

Essa lista de tarefas não tem um CRUD. 

resumo de verbos http para requests
| Verbo  | Endpoint                | Parâmetro | Body          |
|--------|-------------------------|-----------|---------------|
| GET    | /Tarefa/{id}            | id        | N/A           |
| PUT    | /Tarefa/{id}            | id        | Schema Tarefa |
| DELETE | /Tarefa/{id}            | id        | N/A           |
| GET    | /Tarefa/ObterTodos      | N/A       | N/A           |
| GET    | /Tarefa/ObterPorTitulo  | titulo    | N/A           |
| GET    | /Tarefa/ObterPorData    | data      | N/A           |
| GET    | /Tarefa/ObterPorStatus  | status    | N/A           |
| POST   | /Tarefa                 | N/A       | Schema Tarefa |

