using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Blog.Models.Base
{
    public class BaseModel
    {
        [DataMember]
        public int Id { get; set; }
    }
}