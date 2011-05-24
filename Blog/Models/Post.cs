using System;
using System.Web;
using System.ComponentModel;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    [MetadataType(typeof(PostMetaData))]
    public partial class Post
    {
        public class PostMetaData
        {
             public int id{get; set;}
             public DateTime data_dodania { get; set; }
             [DisplayName("Tytuł")]
             [Required(ErrorMessage = "Tytuł jest wymagany")]
             [StringLength(150,ErrorMessage="Za długi tytuł")]
             public String tytul { get; set; }
             [DisplayName("Treść")]
             [Required(ErrorMessage = "Treść jest wymagana")]
             public String tresc { get; set; }
             public DateTime data_modyfikacji { get; set; }
             [DisplayName("Status")]
             public int status { get; set; }
        }
    }
}