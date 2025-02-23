﻿using AutoMapper;
using Bogus;
using Bogus.DataSets;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Domain.Entities;
using Workboard.Domain.Repositories;
using Workboard.Infrastructure.Services;

namespace Workboard.Teste.V1
{
    public class TarefaTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IRepositorioTarefa> _mock;
        private readonly TarefaService _service;

        public TarefaTest()
        {
            _mock = new Mock<IRepositorioTarefa>();
            _service = new TarefaService(_mock.Object);
        }
        [Fact]
        public async Task AdicionaTarefa()
        {
       
            Tarefa t = gerarTarefa();

            _mock.Setup(x => x.Add(t));
            await _service.Add(t);


        }
        [Fact]
        public async Task RemoveTarefa()
        {
           
            Tarefa t = gerarTarefa();

            _mock.Setup(x => x.Remove(t));
            await _service.Remove(t);

        }
        [Fact]
        public async Task UpdateTarefa()
        {
           
            Tarefa t = gerarTarefa();
            _mock.Setup(x => x.Update(t));
            await _service.Update(t);


        }
        [Fact]
        public async void BuscaPorIdTarefa()
        {

            var faker = new Faker();
            var id = faker.Random.Int(1);
            _mock.Setup(x => x.GetById(id));
            await _service.GetById(id);

        }
        [Fact]
        public async Task BuscaTarefa()
        {
            _mock.Setup(x => x.GetAll());
            await _service.GetAll();

        }

        private Tarefa gerarTarefa()
        {
            var faker = new Faker();
            Tarefa t = new Tarefa(faker.Random.Int(1),
                faker.Random.Int(1),
                faker.Random.String(),
                faker.Random.String(),
                faker.Date.Future(),
                faker.Date.Future(),
                faker.Random.String(),
                faker.Random.String());
            return t;
        }
    }
}
