using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Blog.Models
{
    [MetadataType(typeof(TagiMetaData))]
    public partial class Tagi
    {
        public class TagiMetaData
        {
            public int id { get; set; }
            public int id_posta { get; set; }
            [Required(ErrorMessage = "Opis posta jest wymagany")]
            [DisplayName("Opis posta")]
            public string description { get; set; }
            [Required(ErrorMessage = "Słowa kluczowe są wymagane")]
            [DisplayName("Słowa kluczowe")]
            public string keywords { get; set; }
        }
    }
}