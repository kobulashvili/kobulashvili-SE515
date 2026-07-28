using System;
using System.Collections.Generic;
using System.Text;
using Uni.Core.Enums;

namespace Uni.Core.Models
{
    public class Student : Person
    {



        public decimal GPA { get; set; }
        public List<Subjact> subjact { get; set; }







    }
}
