﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GraduationProject.Data
{
    public class Student : BaseEntity
    {
        public string School { get; set; }
        public string Universty { get; set; }
        public string Image { get; set; }
        public string Info { get; set; }
        public bool FirstVisit { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}