
using AutoMapper;
using Bogus;
using Bogus.DataSets;
using Moq;
using Moq.AutoMock;
using Workboard.Application.Mappers;
using Workboard.Domain.Entities;
using Workboard.Domain.Repositories;
using Workboard.Domain.Services;
using Workboard.Infrastructure.Services;


namespace Workboard.Teste.V1
{
    public class ComentarioTest
    {

        private readonly IMapper _mapper;
        private readonly Mock<IRepositorioComentario> _mockComentario;
        private readonly ComentarioService _serviceComentario;

        public ComentarioTest()
        {
            _mockComentario = new Mock<IRepositorioComentario>();
            _serviceComentario=new ComentarioService(_mockComentario.Object);
        }

        [Fact]
        public async Task AdicionaComentario()
        {

            Comentario c = GerarComentario();

           _mockComentario.Setup(x => x.Add(c));
           await _serviceComentario.Add(c);


        }
        [Fact]
        public async Task RemoveComentario()
        {

            Comentario c = GerarComentario();

            _mockComentario.Setup(x=>x.Remove(c));
           await _serviceComentario.Remove(c);

        }
        [Fact]
        public async Task UpdateComentario()
        {
           
            Comentario c = GerarComentario();
            _mockComentario.Setup(x=>x.Update(c));
            await _serviceComentario.Remove(c);


        }
        [Fact]
        public async void BuscaPorIdComentario()
        {
            var faker = new Faker();
            var id = faker.Random.Int(1);
            _mockComentario.Setup(x=>x.GetById(id));
            await _serviceComentario.GetById(id);

        }
        [Fact]
        public async Task BuscaComentarios()
        {
            _mockComentario.Setup(x=>x.GetAll());
            await _serviceComentario.GetAll();

        }
        public static ICollection<Comentario> GerarListaComentario(int qtd)
        {
            var listaComentario = new List<Comentario>();

            var faker = new Faker();
            for (var i = 1; i <= qtd; i++)
            {
                var comentario = new Comentario(
                    id:faker.Random.Int(i),
                    idTarefa:faker.Random.Int(i+1),
                    texto:faker.Random.String(20));

                listaComentario.Add(comentario);
            }

            return listaComentario;
        }
        private Comentario GerarComentario()
        {
            var faker = new Faker();
            Comentario c = new Comentario(faker.Random.Int(1), faker.Random.Int(1), "teste");
            return c;

        }
    }
}