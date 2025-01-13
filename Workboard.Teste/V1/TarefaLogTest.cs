using AutoMapper;
using Bogus;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Application.Enum;
using Workboard.Domain.Entities;
using Workboard.Domain.Repositories;
using Workboard.Infrastructure.Services;

namespace Workboard.Teste.V1
{
    public class TarefaLogTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IRepositorioTarefaLog> _mockLog;
        private readonly TarefaLogService _service;

        public TarefaLogTest()
        {
            _mockLog = new Mock<IRepositorioTarefaLog>();
            _service = new TarefaLogService(_mockLog.Object);
        }
        [Fact]
        public async Task AdicionaTarefaLog()
        {
        
            var dta =DateTime.Now;
            TarefaLog t = gerarTarefa();

            _mockLog.Setup(x => x.Add(t));
            await _service.Add(t);


        }
        [Fact]
        public async Task RemoveTarefaLog()
        {
            
            TarefaLog t = gerarTarefa();
            _mockLog.Setup(x => x.Remove(t));
            await _service.Remove(t);

        }
        [Fact]
        public async Task UpdateTarefaLog()
        {
            
            TarefaLog t = gerarTarefa();
            _mockLog.Setup(x => x.Update(t));
            await _service.Update(t);


        }
        [Fact]
        public async void BuscaPorIdTarefaLog()
        {
            var faker = new Faker();
           
            var id = faker.Random.Int(1);
            _mockLog.Setup(x => x.GetById(id));
            await _service.GetById(id);

        }
        [Fact]
        public async Task BuscaTarefaLog()
        {
            _mockLog.Setup(x => x.GetAll());
            await _service.GetAll();

        }
        private TarefaLog gerarTarefa()
        {
            var faker = new Faker();
            TarefaLog t = new TarefaLog(faker.Random.Int(1),
                faker.Random.Int(1),
                faker.Random.Int(10),
                Domain.Enum.Status.CONCLUIDA,
                faker.Date.Future());
            return t;
        }
    }
}
