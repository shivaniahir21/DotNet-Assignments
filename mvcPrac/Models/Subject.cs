using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Subject
{
    [Key]

    public int ID { get;  set;}

    public string? Subject_Name { get; set;}

    public string? Syllabus { get; set;}

    [Range(1,5)]

    public int credits {get; set;}

}