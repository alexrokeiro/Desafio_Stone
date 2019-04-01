using System;
using System.Collections.Generic;
using Desafio.Domain.Models;
using MongoDB.Driver;
using System.Linq;
using MongoDB.Bson;
using Microsoft.Extensions.Configuration;

namespace Desafio.Infra.DataAcess.MongoDb
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly IMongoClient mongoClient;
        private readonly IMongoDatabase mongoDatabase;

        public FuncionarioRepository(IConfiguration configuration)
        {
            mongoClient = new MongoClient(configuration.GetSection("ConnectionString").Value);

            var databaseName = MongoUrl.Create(configuration.GetSection("ConnectionString").Value).DatabaseName;
            mongoDatabase = mongoClient.GetDatabase(databaseName);
        }

        public void CriarFuncionario(Funcionario funcionario)
        {
            var xxx = mongoDatabase.GetCollection<Funcionario>("funcionarios");
            mongoDatabase.GetCollection<Funcionario>("funcionarios").InsertOne(funcionario);
        }

        public IEnumerable<Funcionario> Listar()
        {
            return mongoDatabase
               .GetCollection<Funcionario>("funcionarios").Find(new BsonDocument()).ToListAsync().Result; 

        }
    }
}
