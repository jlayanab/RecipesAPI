using System;

namespace RecipesAPI.Models
{
    public class User: BaseModel {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}