﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public class Service
	{
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceContent { get; set; }
        public string ServiceIcon { get; set; }
        public bool ServiceStatus { get; set; }
    }
}