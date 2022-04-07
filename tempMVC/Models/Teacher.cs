using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tempMVC.Models{
public class Teacher
{
     [Key]
    public int ID { get; set;}

    public string name { get; set;}

    public DateTime joindate { get; set;}

    public DateTime birthdate { get; set;}
}
}
