﻿using System.ComponentModel.DataAnnotations;

namespace Stations.API.Models.DTO
{
    public class RegisterRequestDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        public string[] Roles { get; set; }
    }
}
