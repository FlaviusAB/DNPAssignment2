﻿using System.Collections.Generic;

namespace LoginExample.Data.Model
{
    public class Family {
    
        //public int Id { get; set; }
        public string StreetName { get; set; }
        public int HouseNumber{ get; set; }
        public List<Adult> Adults { get; set; }
        public List<Child> Children{ get; set; }
        public List<Pet> Pets{ get; set; }

        public Family() {
            Adults = new List<Adult>();     
        }
    }


}