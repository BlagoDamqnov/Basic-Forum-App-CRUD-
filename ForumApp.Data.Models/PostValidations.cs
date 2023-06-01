namespace ForumApp.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class PostValidations
    {
        public static class Post
        {
            public const int TitleMaxLength = 30;
            public const int ContentMaxLength = 1500;
        }
    }
}
