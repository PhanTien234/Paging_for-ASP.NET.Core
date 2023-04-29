using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace razorweb2.models{
   
   //muốn đổi tên bảng khi develoy lên SQL server thì ta dùng [Table("nametable muon doi")] razorweb2.models.Article
    public class Article{

        [Key]
        public int Id {get; set;}
        [StringLength(255)]
        [Required]
        [Column(TypeName = "nvarchar")]
        [DisplayName("Titles")]
        public string Title {get; set;}
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("Created at")]
        public DateTime Created {get; set;}
        [Column(TypeName = "ntext")]
        [DisplayName("Content")]
        public string Content {get; set;}

    }

}