# Workboard

O projeto Workboard é uma aplicação desenvolvida em C# que utiliza o Entity Framework Core para gerenciar tarefas e projetos de forma eficiente.

Funcionalidades
Gerenciamento de Tarefas: Criação, edição e exclusão de tarefas.
Gerenciamento de Projetos: Organização de tarefas em projetos distintos.
Acompanhamento de Status: Monitoramento do progresso de cada tarefa.


Pré-requisitos
.NET 7 SDK
SQL Server
Configuração
Clone o repositório:

git clone https://github.com/Danielaaaamaral/Workboard.git
cd Workboard\Workboard

Configurar a String de Conexão

Atualize a string de conexão no arquivo appsettings.json do projeto EW.TaskManagement.API para apontar para o seu servidor SQL Server.

Exemplo de appsettings.json:

{ "ConnectionStrings": {
   "DefaultConnection": "Server=host.docker.internal,1433;Database=worboard;User Id=worboard_api;Password=Teste123!;TrustServerCertificate=True;",
   "LocalConnection": "Server=localhost\\SQLEXPRESS;Database=worboard;persist security info=True;Integrated Security=true;Trusted_Connection=True; Encrypt=False;"
 }
}

Execute as migrações do banco de dados:

No diretório raiz do projeto, execute:
dotnet ef database update


Execução
Para iniciar a aplicação, utilize o comando:

dotnet run --project Workboard

Testes
Para executar os testes unitários, utilize:


dotnet test

Para mais informações, visite o repositório no GitHub: https://github.com/Danielaaaamaral/Workboard.

------------------------------------------------------------------------------------------------------------------------------------------

Questões para Product Owner

Sobre Interface e Navegação do usuario final 
Há feedback de usuários sobre a facilidade de uso da interface atual?
Existe interesse em personalização da interface ?

Sobre funcionalidades já existentes
Existe necessidade de criar dependencia entre tarefas?
Usuario necessidade de alertas sobre prazos vencidos ou proximos do vencimento ?
Quais tipos de relatorios ou metricas são mais eficientes para usuario?
necessidade de relatorios mais detalhados?
Há planos de expansão para outras plataformas, como um aplicativo móvel?
Existem áreas onde os usuários relatam lentidão ou problemas de desempenho?

-------------------------------------------------------------------------------------------------------------------------------------------
Melhorias para Projeto 

Desenvolvimento de processo em microsserviços por exemplo de funcionalidade Relatorios.
Adicionar caching para operações frequente usando ferramentas como Redis.
Desenvolvimento de novas implementações conforme respostas do PO e experiencia do usuario
Melhorar a documentação interna e externa do projeto, incluindo comentários de código, guias de configuração e documentação de API para facilitar o entendimento e a colaboração da equipe.





