using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KKEventManager.Models
{
    public class User
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Sex Sex { get; private set; }
        public Adress Adress { get; set;}
    }
}