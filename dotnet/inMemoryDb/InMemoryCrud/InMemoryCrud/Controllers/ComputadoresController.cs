using InMemoryCrud.Application.Interface;
using InMemoryCrud.Domain.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace InMemoryCrud.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComputadoresController : ControllerBase
    {
        private readonly IComputadoresServices _computadoresServices;

        public ComputadoresController(IComputadoresServices computadoresServices)
        {
            _computadoresServices = computadoresServices;
        }

        [HttpGet("[action]")]
        public List<ComputadoresModel> ListarConputadores()
        {
            return _computadoresServices.Listar();
        }

        [HttpGet("[action]")]
        public ComputadoresModel BuscaPorId(Guid id)
        {
            return _computadoresServices.BuscaPorId(id);
        }

        [HttpDelete("[action]")]
        public ActionResult DeletePorId(Guid id)
        {
            _computadoresServices.DeletePorId(id);
            return Ok();
        }

        [HttpPost("[action]")]
        public ActionResult Cadastrar(ComputadoresModel computadores)
        {
            _computadoresServices.Cadastrar(computadores);
            return Ok();
        }
    }
}