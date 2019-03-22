using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Activity_Center.Models
{
    public class User
    {
        [Key]
        [Required]
        public int UserId { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z]{1,25}$", ErrorMessage="Numbers are not allowed in your name")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z]{1,25}$", ErrorMessage="Numbers are not allowed in your name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-_]).{8,}$", ErrorMessage="Password must contain at least 1 number, 1 letter and a special character")]
        [MinLength(8)]
        public string Password { get; set; }

        public List<Association> Activities { get; set; }

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
    }

    public class Event
    {
        [Key]
        [Required]
        public int EventId { get; set; }
        [Required]
        [MinLength(2)]
        public string Title { get; set; }
        [Required]
        [DataType (DataType.DateTime)]
        public DateTime StartTime { get; set; }

        [DataType (DataType.DateTime)]
        public DateTime EndTime { get; set; }
        [Required]
        public int Duration { get; set; }
        public string TimeType { get; set; }
        [Required]
        [MinLength(10)]
        public string Description { get; set; }

        public int UserId { get; set; }
        public User Creator { get; set; }
        public List<Association> Participants { get; set; }
    }

    public class Association
    {
        public int AssociationId { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public User User { get; set; }
        public Event Event { get; set; }
    }

    public class UserLogin
    {
        [Required]
        [EmailAddress]
        public string LogEmail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string LogPassword { get; set; }
    }
}