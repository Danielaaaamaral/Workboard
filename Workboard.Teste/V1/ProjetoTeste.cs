using AutoMapper;
using Bogus;
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
    public class ProjetoTeste
    {
        private readonly IMapper _mapper;
        private readonly Mock<IRepositorioProjeto> _mock;
        private readonly ProjetoService _service;

        public ProjetoTeste()
        {
            _mock = new Mock<IRepositorioProjeto>();
            _service = new ProjetoService(_mock.Object);
        }
        [Fact]
        public async Task AdicionaProjeto()
        {

            Projeto t = gerarProjeto();

            _mock.Setup(x => x.Add(t));
            await _service.Add(t);


        }
        [Fact]
        public async Task RemoveProjeto()
        {

            Projeto t = gerarProjeto();

            _mock.Setup(x => x.Remove(t));
            await _service.Remove(t);

        }
        [Fact]
        public async Task UpdateProjeto()
        {

            Projeto t = gerarProjeto();
            _mock.Setup(x => x.Update(t));
            await _service.Update(t);


        }
        [Fact]
        public async void BuscaPorIdProjeto()
        {

            var faker = new Faker();
            var id = faker.Random.Int(1);
            _mock.Setup(x => x.GetById(id));
            await _service.GetById(id);

        }
        [Fact]
        public async Task BuscaProjeto()
        {
            _mock.Setup(x => x.GetAll());
            await _service.GetAll();

        }

        private Projeto gerarProjeto()
        {
            var faker = new Faker();
            Projeto p = new Projeto(
                faker.Random.Int(1),
                faker.Random.Int(),
                faker.Date.Future(),
                faker.Random.String());
          
            return p;
        }
    }
}
