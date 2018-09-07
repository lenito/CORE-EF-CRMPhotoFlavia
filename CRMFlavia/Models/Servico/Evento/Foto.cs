using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRMFlavia.Models.Servico
{
    public class Foto : BaseModel
    {
        public Foto(Galeria galeria, string urlImagem, bool selecionadaAlbum, bool selecionadaFavoritos, DateTime dataAdicionada)
        {
            Galeria = galeria;
            UrlImagem = urlImagem;
            SelecionadaAlbum = selecionadaAlbum;
            SelecionadaFavoritos = selecionadaFavoritos;
            DataAdicionada = dataAdicionada;
        }

        [Required]
        public Galeria Galeria { get; set; }
        [Required]
        public string UrlImagem { get; set; }
        public bool SelecionadaAlbum { get; set; }
        public bool SelecionadaFavoritos { get; set; }
        public DateTime DataAdicionada { get; set; }
    }
}
