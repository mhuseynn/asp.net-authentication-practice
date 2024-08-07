using Authentication.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Authentication.Models;


public class User
{
    public User()
    {
        
    }
    public User(string name, int age, string email, string password)
    {
        Name = name;
        Age = age;
        Email = email;
        Password = password;
    }

    
    public string Name { get; set; }

    public int Age { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

}
