﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scrumban.Models
{
    public class Feature
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public int? StateID { set; get; }
        public State State { get; set; }

        public int? OwnerID { set; get; }
        public Owner Owner { get; set; }
        public int? ReleaseID { set; get; }
        public int? Priority { set; get; }
      //public List<Story> Stories { set; get; }
        public DateTime Time { set; get; }

    }

}
