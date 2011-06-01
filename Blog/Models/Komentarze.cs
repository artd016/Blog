using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Blog.Models
{
    [MetadataType(typeof(KomentarzeMetaData))]
    public partial class Komentarze
    {
        public class KomentarzeMetaData
        {
            public int id { get; set; }
            public int id_posta { get; set; }
            [DisplayName("Treść")]
            [Required(ErrorMessage = "Pole treść jest wymagane")]
            public string tresc { get; set; }
            [DisplayName("Autor")]
            [Required(ErrorMessage = "Pole autor jest wymagane")]
            [StringLength(50, ErrorMessage = "Za długa nazwa autora")]
            public string autor { get; set; }
            [DisplayName("Data dodania")]
            public DateTime data_dodania { get; set; }
            [DisplayName("Status")]
            public int status { get; set; }
        }
    }
}