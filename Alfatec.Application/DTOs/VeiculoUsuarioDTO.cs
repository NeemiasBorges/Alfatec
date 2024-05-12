using System;
using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class VeiculoUsuarioDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A marca do veículo é obrigatória")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O modelo do veículo é obrigatório")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "O ano do veículo é obrigatório")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "A placa do veículo é obrigatória")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "A cor do veículo é obrigatória")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "O tipo de combustível do veículo é obrigatório")]
        public string TipoCombustivel { get; set; }

        [Required(ErrorMessage = "A capacidade do tanque do veículo é obrigatória")]
        public double CapacidadeTanque { get; set; }

        [Required(ErrorMessage = "A data da última manutenção do veículo é obrigatória")]
        public DateTime DataUltimaManutencao { get; set; }

        public string Observacoes { get; set; }

        [Required(ErrorMessage = "O ID do usuário é obrigatório")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "O ID do veículo é obrigatório")]
        public int VeiculoId { get; set; }

        public int TipoObjeto { get; set; } = 22;
    }
}
