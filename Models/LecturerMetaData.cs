using Microsoft.AspNetCore.Mvc;
using SchoolManagementApp.MVC.Data;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementApp.MVC.Data;

public class LecturerMetaData
{
    [StringLength(50)]
    [Display(Name = "First Name")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last Name")]
    public string LastName { get; set; } = null!;

    [Required]
    [Display(Name = "Data Of Birth")]
    public DateTime? DateOfBirth { get; set; }
}

[ModelMetadataType(typeof(LecturerMetaData))]
public partial class Lecturer { }
