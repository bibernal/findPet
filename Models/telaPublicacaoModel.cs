namespace findPet.Models
{
    public class telaPublicacaoModel
    {
        public required string Nome { get; set; }
        public required string Raca { get; set; }
        public required string Cor { get; set; }
        public required string Porte { get; set; }
        public required string LocalDesaparecimento { get; set; }
        public required DateTime DataDesaparecimento { get; set; }
    }
}

