using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication5.Models
{
    public class Course
    {

        //[Required]
        //[MaxLength(100)]
        public string Title { get; set; }
            public string CourseCode { get; set; }
            
        
            

    }
}