//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC5Demo.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Employee
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required, Display(Name = "Employee Name")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public System.DateTime HiredDate { get; set; }

        [Required, Display(Name = "Email address")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please provide valid Email address")]
       
        public string Email { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int Department_Id { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
