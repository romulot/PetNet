using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetNet.DataAccess.Contexts;
using PetNet.DomainModel.Entities;
using PetNet.DomainModel.Interfaces.Repositories;

namespace PetNet.DataAccess.Repositories
{
    public class NotificationEntityFrameworkRepository : INotificationRepository
    {
        public void Create(Notification notification)
        {
            var notificationContext = new SocialNetworkContext();
            notificationContext.Notifications.Add(notification);
            notificationContext.SaveChanges();
        }

        public IEnumerable<Notification> ReadAll(Profile recipient)
        {
            var notificationContext = new SocialNetworkContext();
            return notificationContext.Notifications;
        }
    }
}
