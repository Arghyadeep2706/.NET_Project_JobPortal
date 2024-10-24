﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace JobServicePortal.Models;

public partial class JobPost
{
    public int JobId { get; set; }

    public int CompanyId { get; set; }

    public string JobTitle { get; set; }

    public string JobDescription { get; set; }

    public string SalaryRange { get; set; }

    public string JobLocation { get; set; }

    public DateOnly PostDate { get; set; }

    public int? ExperienceRequired { get; set; }

    public string MinimumQualification { get; set; }

    public string JobType { get; set; }

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    public virtual Company Company { get; set; }

    public virtual ICollection<SavedJob> SavedJobs { get; set; } = new List<SavedJob>();
}