using AutoMapper;
using InMemoryCrud.Application.Interface;
using InMemoryCrud.Domain.Core.Model;
using InMemoryCrud.Infrastructure.Interface;

namespace InMemoryCrud.Application.Services
{
    public class ComputadoresServices : IComputadoresServices
    {
        private readonly IComputadoresRepository _repository;
        private readonly IMapper _mapper;

        public ComputadoresServices(IComputadoresRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<ComputadoresModel> Listar()
        {
            return _mapper.Map<List<ComputadoresModel>>(_repository.Listar());
        }

        public ComputadoresModel BuscaPorId(Guid id)
        {
            return _mapper.Map<ComputadoresModel>(_repository.BuscaPorId(id));
        }
        public void DeletePorId(Guid id)
        {
            _repository.DeletePorId(id);
        }

        public void Cadastrar(ComputadoresModel computadores)
        {
            _repository.Cadastar(_mapper.Map<ComputadoresDataModel>(computadores));
        }
    }
}
