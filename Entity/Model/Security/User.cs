﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Security
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password{ get; set; }
        public string CreateAt { get; set; }
        public string UpdateAt { get; set; }
        public string DeleteAt { get; set; }
        public bool State { get; set; }
        public List<User> ltsUsers { get; set; }
    }
}
