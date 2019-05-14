using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetNet.DomainModel.Interfaces.Repositories;

namespace PetNet.DomainModel.Entities
{
    public class Post : EntityBase
    {
        public Profile Sender { get; set; }
        public Profile Recipient { get; set; }
        public Group Group { get; set; }
        public Profile Author { get; set; }

        public DateTime PublishDateTime { get; set; }
        public string Content { get; set; }

        public Post()
        {
            PublishDateTime = DateTime.Now;
        }
    }
}
