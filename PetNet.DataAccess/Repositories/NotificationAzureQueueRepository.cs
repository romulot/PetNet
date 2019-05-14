using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetNet.AzureStorageAccount;
using PetNet.DomainModel.Entities;
using PetNet.DomainModel.Interfaces.Repositories;

namespace PetNet.DataAccess.Repositories
{
    public class NotificationAzureQueueRepository : INotificationRepository
    {
        public void Create(Notification notification)
        {
            var queueService = new QueueService();
            queueService.Enqueue(notification.Recipient.Id.ToString(),
                notification.ToString());
        }

        public IEnumerable<Notification> ReadAll(Profile recipient)
        {
            var queueService = new QueueService();
            var notifications = new List<Notification>();
            string notificationStr = queueService.Dequeue(recipient.Id.ToString());
            while (!string.IsNullOrEmpty(notificationStr))
            {
                notifications.Add(Notification.Parse(notificationStr));
                notificationStr = queueService.Dequeue(recipient.Id.ToString());
            }
            return notifications;
        }
    }
}
