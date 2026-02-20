namespace rebucados.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public string Produtos { get; set; }
        public int Quantidade { get; set; }
        public int VendedorId { get; set; }
    }
}
