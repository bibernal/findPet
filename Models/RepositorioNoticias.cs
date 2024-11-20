namespace findPet.Models
{
    public static class RepositorioNoticias
    {
        private static List<Noticia> noticias = new List<Noticia>()
        {
            new Noticia {Id = 1,
                Cabecalho = "Novidade em IA",
                ImagemUrl = "https://super.abril.com.br/wp-content/uploads/2019/12/reproducao_pokemon_episodio_pokemon_centenas_criancas_hospital.jpg? quality=70&strip=info&w=675&h=450&crop=1",
                Texto = "Meus olhos são infantis, mas eles conseguem ver o desespero nos seus -Joe Jouki"
            },

            new Noticia {Id = 2,
                Cabecalho = "Vem comigo",
                ImagemUrl = "https://i.pinimg.com/200x150/c3/bc/4d/c3bc4d8e2dd8d186c74ef1d301fb5639.jpg",
                Texto = "Hoje eu não sou Cesar, eu não sou Kaiser, eu sou o Angel Of The Night - Cesar Corren"
            }
        };

        public static IEnumerable<Noticia> Noticias => noticias;

        public static int AdicionarNoticia(Noticia noticia)
        {
            noticia.Id = noticias.Max(n => n.Id) + 1;
            noticias.Add(noticia);

            return noticia.Id;
        }

        public static void RemoverNoticia(int Id)
        {
            var noticia = noticias.FirstOrDefault(n => n.Id == Id);

            if(noticia != null){
                noticias.Remove(noticia);
            }
        }
    }

}