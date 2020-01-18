using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class GroomService
    {
        [Key]
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        //decribe in decimal with 2 decimal number (i.e.: 2.25 CAD)
        public decimal ServiceCost { get; set; }
        //describe in hours (i.e.: 0.25 hours)
        public decimal ServiceDuration { get; set; }
        /*
            A GroomService is a type of activity that a Groomer can do for a pet. Some examples might be nail clipping, shampoo, trim, etc.
            
            Some things that describe a GroomService
                - Service Name
                - Cost
                - Duration
         */
    }
}