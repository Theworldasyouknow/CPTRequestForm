﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Internship.ViewModels
{
    public class IntContext : DbContext
    {
        DbSet<Application> Application { get; set; }
        DbSet<CPTform> CPTform { get; set; }
        DbSet<Employer> Employer { get; set; }
        DbSet<User> User { get; set; }
        DbSet<EmployementAgreement> EmployementAgreement { get; set; }
        DbSet<LearningObjective> LearningObjective { get; set; }




    }


}