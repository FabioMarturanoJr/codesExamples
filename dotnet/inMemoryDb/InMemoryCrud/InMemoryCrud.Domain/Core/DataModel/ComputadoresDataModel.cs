using System.ComponentModel.DataAnnotations;

namespace InMemoryCrud.Domain.Core.Model
{
    public class ComputadoresDataModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Valor { get; set; }
        public string Fornecedor { get; set; }
        public string Cor { get; set; }
    }
}