using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TheCorridorGroupMd.Models
{
    public class PotentialClients

    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName="varchar")]
        [Display(Name ="First Name")]
        public string FirstName { get; set;}

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        // public int PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        public string Name
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }

        //The ApplicationUser Id, on PotentialClients, was created as a nullable column. 
        //If there is no notation there, there is no constraint present.  So in this case
        //you added a required attribute [Required] to that property. And with automatic migrations enabled, 
        //to push the change to the database you made to this file that did not have
        //a [Required] attribute on ApplicationUserId when it was generated, you run 'Update-Database -Verbose


            //Entity Framework, is smart enough to know that you are talking about
            //the Id property, of the related ApplicationUser entity. 
        [Required]
        public string ApplicationUserId { get; set; }

        //In this class, you will add another property, a public virtual ApplicationUser User, 
        //that will be a reference to the user that holds this account. And it will be 
        //automatically implemented with a foreign key that refrences the User table, 
        //when your database is generated. Making it a virtual property, allows it to be 
        //overidden by the framework with a mechanism that supports lazy loading, of this 
        //related object. So you can actually assign a user object to this property, 
        //and have that user object be updated in the database. But it's going to be a lot more
        //convenient in some scenarios, to just assign a UserId.  

        public virtual ApplicationUser User { get; set; }
       




    }
}