﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Client
    {
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string  Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}