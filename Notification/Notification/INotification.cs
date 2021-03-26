using System;
using System.Collections.Generic;
using System.Text;

namespace Notification
{
    public interface INotification
    {
        void CreateNotification(String title, String message);
    }
}
