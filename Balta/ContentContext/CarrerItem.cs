using Balta.NotificationContext;
using Balta.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public class CarrerItem : Base
    {
        public CarrerItem(int order, string title, string description, Course course)
        {
            if (course == null)
                AddNotification(new Notification("Course", "O curso não pode ser nulo"));

            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}
