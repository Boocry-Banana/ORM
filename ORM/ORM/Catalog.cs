﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace ORM
{
    [Database]
    public class Catalog : DataContext
    {

        public  Catalog(int _typeBdd ,string _urlBdd) : base(_urlBdd) { }
        public Catalog() : base("NULL") { }

        private string urlBdd { get; set; } = "NULL";
        private int typeBdd { get; set; }
        public Table<Contact> contact;

    }
}

