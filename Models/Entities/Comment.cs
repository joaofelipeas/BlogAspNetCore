using System;
using Blog.Models.Base;

namespace Blog.Models.Entities
{
    public class Comment : BaseModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DtCreate { get; set; }

        public string Author { get; set; }

        public byte[] Image { get; set; }
    }
}