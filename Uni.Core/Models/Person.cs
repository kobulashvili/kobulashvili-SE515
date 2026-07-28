using System;
using System.Collections.Generic;
using System.Text;
using Uni.Core.Enums;

namespace Uni.Core.Models
{
    public class Person
    {
        public int Id { get; set; } 
        public string  Name { get; set; }   
        public int Age { get; set; }   
        
        public string Email { get; set; }

        public string password { get; set; }  
        public string verifies { get; set; }
        public bool IsVerifies { get; set; } = false;

        public Gender Gender { get; set; }




    }
}
