using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KKEventManager.Models
{
    public class Event
    {
        public DateTime Date { get; private set; }
        public string Name { get; set; }
        private Adress Adress { get; set; }
        private List<User> UserList { get; private set;}
    }
}