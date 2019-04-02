# Desafio_Stone


Camadas.
- Host: Camada responsável por receber o request.
- Application: Camada responsável em transformar o request em dtos ou apenas passar os parametros para o domínio. Criado para isolar a camada de domínio.
- Domain: Camada responsável pelas regras de negócio.
- Infrastructure : Camada responsável pelo acesso a banco e injeção de dependência.
- Test: Camada responsável pelos testes.

Persistencia dos dados.
- Utilizei o MongoDB.

Melhorias.
- Criar uma classe para retornar as chamadas. Por exemplo um responseMessage. Onde ele iria conter uma classe base e todos os responses iriam herdar essa classe base. 
Nesse ResponseMessage podemos ter mensagens de validação por exmeplo.
- Criar mais testes para ober uma melhor cobertura de código.
- Poderia deixar a classe de Funcionário abstrata para que a classe de cada tipo pudesse utilizar e sobreescrever algum método caso fosse necessário.
- Criar uma classe responsável pelo retorno das models, entity e task. Por exemplo um DomainResponse, onde ele iria conter uma classe base e mensagem de validação. 
