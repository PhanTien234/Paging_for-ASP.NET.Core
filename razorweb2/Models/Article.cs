using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace razorweb2.models{
   
   //muốn đổi tên bảng khi develoy lên SQL server thì ta dùng [Table("nametable muon doi")] razorweb2.models.Article
    public class Article{

        [Key]
        public int Id {get; set;}
        [StringLength(255, MinimumLength = 5, ErrorMessage = "{0} must be strength from {2} to {1}")]
        [Required(ErrorMessage = "{0} must type")]
        [Column(TypeName = "nvarchar")]
        [DisplayName("Titles")]
        public string Title {get; set;}
        [DataType(DataType.Date)]
        [Required (ErrorMessage = "{0} must type")]
        [DisplayName("Created at")]
        public DateTime Created {get; set;}
        [Column(TypeName = "ntext")]
        [DisplayName("Content")]
        public string Content {get; set;}

    }

}