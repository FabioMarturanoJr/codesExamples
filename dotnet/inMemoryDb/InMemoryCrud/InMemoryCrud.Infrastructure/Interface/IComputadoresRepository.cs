using InMemoryCrud.Domain.Core.Model;

namespace InMemoryCrud.Infrastructure.Interface
{
    public interface IComputadoresRepository
    {
        List<ComputadoresDataModel> Listar();
        void Cadastar(ComputadoresDataModel model);
        ComputadoresDataModel BuscaPorId(Guid id);
        void DeletePorId(Guid id);
    }
}
