using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetNet.DomainModel.Entities
{
    public class FriendshipRequest : EntityBase
    {
        public Profile Requester { get; set; }
        public Profile Requested { get; set; }
    }
}
