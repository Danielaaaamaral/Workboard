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
    public class UsuarioTeste
    {
        private readonly IMapper _mapper;
        private readonly Mock<IRepositorioUsuario> _mock;
        private readonly UsuarioService _service;

        public UsuarioTeste()
        {
            _mock = new Mock<IRepositorioUsuario>();
            _service = new UsuarioService(_mock.Object);
        }
        [Fact]
        public async Task AdicionaUsuario()
        {

            var t = gerarUsuario();

            _mock.Setup(x => x.Add(t));
            await _service.Add(t);


        }
        [Fact]
        public async Task RemoveUsuario()
        {

            var t = gerarUsuario();

            _mock.Setup(x => x.Remove(t));
            await _service.Remove(t);

        }
        [Fact]
        public async Task UpdateUsuario()
        {

            var t = gerarUsuario();
            _mock.Setup(x => x.Update(t));
            await _service.Update(t);


        }
        [Fact]
        public async void BuscaPorIdUsuario()
        {

            var faker = new Faker();
            var id = faker.Random.Int(1);
            _mock.Setup(x => x.GetById(id));
            await _service.GetById(id);

        }
        [Fact]
        public async Task BuscaUsuario()
        {
            _mock.Setup(x => x.GetAll());
            await _service.GetAll();

        }

        private Usuario gerarUsuario()
        {
            var faker = new Faker();
            Usuario u =new Usuario(
                faker.Random.Int(1),
                faker.Random.String(),
                faker.Date.Future(),
                tipoUsuario.Gerente
                );
           

            return u;
        }
    }
}
