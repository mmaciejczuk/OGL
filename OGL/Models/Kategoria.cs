using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OGL.Models
{
    public class Kategoria
    {
        public Kategoria()
        {
            this.Ogloszenie_Kategoria = new HashSet<Ogloszenie_Kategoria>();
        }


    }
}