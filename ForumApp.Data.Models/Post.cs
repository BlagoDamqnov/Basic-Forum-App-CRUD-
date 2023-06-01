using System.ComponentModel.DataAnnotations;

namespace ForumApp.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    using static ForumApp.Data.Models.PostValidations.Post;
    public class Post
    {
        public int Id { get; set; }

        [Required] 
        [MaxLength(TitleMaxLength)] 
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; } = null!;

    }
}
