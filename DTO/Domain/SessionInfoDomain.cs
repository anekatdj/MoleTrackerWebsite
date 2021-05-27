using System;
using System.Collections.Generic;
using System.Text;

namespace DataClasses.Domain
{
    public class SessionInfoDomain
    {
        public int SessionID { get; set; }
        public int LoginID { get; set; }
        public string LoginType { get; set; }
        public bool LoggedIn { get; set; } = false;
        public int UseID { get; set; }
    }
}
