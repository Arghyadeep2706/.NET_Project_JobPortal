﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace JobServicePortal.Models;

public partial class EducationalQualification
{
    public int UserId { get; set; }

    public string Degree { get; set; }

    public string Institution { get; set; }

    public string FieldOfStudy { get; set; }

    public int GraduationYear { get; set; }

    public decimal? Cgpa { get; set; }

    public virtual JobApplicant User { get; set; }
}