using Microsoft.AspNetCore.Mvc;
using SchoolManagementApp.MVC.Data;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementApp.MVC.Data;

public class StudentMetaData
{
    [StringLength(50)]
    [Display(Name ="First Name")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last Name")]
    public string LastName { get; set; } = null!;

    [Required]
    [Display(Name = "Data Of Birth")]
    public DateTime? DateOfBirth { get; set; }
}

[ModelMetadataType(typeof(StudentMetaData))]
public partial class Student{ }
