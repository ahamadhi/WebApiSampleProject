﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSampleProject.Models
{
    public class Customer
    {
        public int CustomerId
        {
            get;
            set;
        }
        public string CustomerName
        {
            get;
            set;
        }
        public string CustomerAddress
        {
            get;
            set;
        }
        public string InsurerName
        {
            get;
            set;
        }
    }
}