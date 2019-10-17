using System;
using System.Collections.Generic;
using System.Text;

namespace TriggersStanding.Models
{
    using System.Collections.Generic;
    public class user
    {

        public string Name { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string Img { get; set; }
        public bool Active { get; set; }
        public List<string> Lcitas { get; set; }

        public user()
        {
            Lcitas = new List<string>();
        }

    }

}
