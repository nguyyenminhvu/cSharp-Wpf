﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v1BuildCRUD.Model.UserModel
{
    public class Users
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
