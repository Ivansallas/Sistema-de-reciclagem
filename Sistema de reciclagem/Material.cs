namespace Sistema_de_reciclagem
{
    public class Material
    {
        public string Nome { get; set; }
        public decimal PrecoPorKg { get; set; }

        public override string ToString() => Nome; // para exibir no ComboBox
    }
}
