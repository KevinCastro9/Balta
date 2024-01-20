using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Balta.NotificationContext
{
    public abstract class Notifiable
    {
        protected Notifiable() 
        {
            Notifications = new List<Notification>();
        }
        public List<Notification> Notifications { get; set; }
        public bool IsInvalid => Notifications.Any();
        //Seria o mesmo que fazer:
        // public bool IsInvalid { get { return Notifications.Any(); } }

        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AddNotifications(IEnumerable<Notification> notification)
        {
            Notifications.AddRange(notification);
        }
    }
}
