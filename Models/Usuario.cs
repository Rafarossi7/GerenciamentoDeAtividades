namespace GerenciamentoAtividadesApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public required string Nome  { get; set; }
        public required string Email  { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public bool Ativo { get; set; } = true;

    }
}
