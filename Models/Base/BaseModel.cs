using System.Runtime.Serialization;

namespace Blog.Models.Base
{
    public class BaseModel
    {
        [DataMember]
        public int Id { get; set; }
    }
}