using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
namespace Hotel_Management_System.Models
{
    public class User
    {
        
      
        public int UserId { get; set; }
        
        public string WorkDomain { get; set; }
     
        public string UserName { get; set; }
      

        public string Password { get; set; }
     

        public string RePassword { get; set; }
    }
}