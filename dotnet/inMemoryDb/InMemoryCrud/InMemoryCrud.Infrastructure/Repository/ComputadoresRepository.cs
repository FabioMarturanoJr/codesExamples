using InMemoryCrud.Domain.Core.Model;
using InMemoryCrud.Infrastructure.Context;
using InMemoryCrud.Infrastructure.Interface;

namespace InMemoryCrud.Infrastructure.Repository
{
    public class ComputadoresRepository : IComputadoresRepository
    {
        private readonly DataBaseContext _dataBaseContext;

        public ComputadoresRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public List<ComputadoresDataModel> Listar()
        {
            return _dataBaseContext.Computadores.ToList();
        }

        public void Cadastar(ComputadoresDataModel model)
        {
            model.Id = Guid.NewGuid();
            _dataBaseContext.Computadores.Add(model);
            _dataBaseContext.SaveChanges();
        }

        public ComputadoresDataModel BuscaPorId(Guid id)
        {
            return _dataBaseContext.Computadores.FirstOrDefault(c => c.Id.Equals(id));
        }

        public void DeletePorId(Guid id)
        {
            _dataBaseContext.Computadores.Remove(BuscaPorId(id));
            _dataBaseContext.SaveChanges();
        }
    }
}
