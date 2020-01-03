﻿using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCB.Domain.Entities.Administration
{
    public class ApplicationUser
    {
        [PrimaryKey]
        public int UserId { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}