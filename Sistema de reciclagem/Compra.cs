using System;

namespace Sistema_de_reciclagem
{
    public class Compra
    {
        public string Catador { get; set; }
        public Material Material { get; set; }
        public decimal QuantidadeKg { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;

        public decimal ValorTotal => Material != null ? Material.PrecoPorKg * QuantidadeKg : 0;
    }
}
