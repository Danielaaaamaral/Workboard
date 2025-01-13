
using AutoMapper;
using Bogus;
using Bogus.DataSets;
using Moq.AutoMock;
using Workboard.Application.Mappers;
using Workboard.Domain.Entities;
using Workboard.Domain.Repositories;


namespace Workboard.Teste.V1
{
    public class ComentarioTest
    {
        private readonly AutoMocker _mocker = new();
        private readonly IMapper _mapper;

        public ComentarioTest()
        {
        }

        [Fact]
        public void AdicionaComentario()
        {
            var faker = new Faker();
            Comentario c = new Comentario(faker.Random.Int(1), faker.Random.Int(1), "teste");

            _mocker.GetMock<IRepositorioComentario>().Setup(r => r.Add(c));

        }
        public void RemoveComentario()
        {
            var faker = new Faker();
            Comentario c = new Comentario(faker.Random.Int(1), faker.Random.Int(1), "teste");

            _mocker.GetMock<IRepositorioComentario>().Setup(r => r.Remove(c));

        }
        public void UpdateComentario()
        {
            var faker = new Faker();
            Comentario c = new Comentario(faker.Random.Int(1), faker.Random.Int(1), "teste");

            _mocker.GetMock<IRepositorioComentario>().Setup(r => r.Update(c));

        }
        public void BuscaPorIdComentario()
        {
            var faker = new Faker();
            var id = faker.Random.Int(1);
            _mocker.GetMock<IRepositorioComentario>().Setup(r => r.GetById(id));

        }
        public void BuscaComentarios()
        {
            _mocker.GetMock<IRepositorioComentario>().Setup(r => r.GetAll());

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
    }
}