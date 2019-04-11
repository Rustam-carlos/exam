using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Serialization
{
    [Serializable]
    public class User
    {
        [NonSerialized]
        public int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}