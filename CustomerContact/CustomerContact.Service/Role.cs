using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace CustomerContact.Service
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
    }
}
