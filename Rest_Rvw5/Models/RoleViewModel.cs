﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Rest_Rvw5.Models
{
    public class RoleViewModel
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
