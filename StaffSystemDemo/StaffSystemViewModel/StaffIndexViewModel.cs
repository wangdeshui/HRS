﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy.Generators.Emitters;

namespace StaffSystemViewModel
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            StaffList = new List<Staff>();
        }
        public List<Staff> StaffList { get; set; }
        
        public class Staff
        {

            public int Id { get; set; }
           
            public string Name { get; set; }
            public DateTime? BirthDay { get; set; }
            public string School { get; set; }
            public string Address { get; set; }
            public string WorkExperience { get; set; }
            public string SelfAssessment { get; set; }
            public int? Lock { get; set; }
            public string Picture { get; set; }
            public string Attachment { get; set; }
        }
    }
}
