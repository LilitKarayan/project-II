﻿using System;
using System.ComponentModel.DataAnnotations;

namespace NeutrackAPI.DTOs
{
    public class NutritionistCreateDTO
    {
        [Required(ErrorMessage = "Email is required")]
        [MaxLength(60)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
            ErrorMessage = "Email is invalid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.{8,16}$)(?=.*?[a-z])(?=.*?[0-9]).*$",
            ErrorMessage = "Password must be between 8 - 16 characters, should contain at least one digit and a lower case.")]
        [MaxLength(256)]
        public string Password { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Gender { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int YearsOfExperience { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}