﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace JobServicePortal.Models;

public partial class ProfessionalDetail
{
    public int UserId { get; set; }

    public string CurrentCompany { get; set; }

    public string CurrentRole { get; set; }

    public decimal? TotalExperienceYears { get; set; }

    public string NoticePeriod { get; set; }

    public virtual JobApplicant User { get; set; }
}