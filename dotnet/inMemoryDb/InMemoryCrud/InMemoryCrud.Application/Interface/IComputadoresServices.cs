using InMemoryCrud.Domain.Core.Model;

namespace InMemoryCrud.Application.Interface
{
    public interface IComputadoresServices
    {
        List<ComputadoresModel> Listar();
        void Cadastrar(ComputadoresModel computadores);
        ComputadoresModel BuscaPorId(Guid id);
        void DeletePorId(Guid id);
    }
}
