﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Internship.ViewModels;



namespace Internship.ViewModels
{
    public class Application
    {
        [Key, ForeignKey("ApplicationId")]
        public int Id { get; set; }
        public virtual Application ApplicationId { get; set; }
        [ForeignKey("CPTform")]
        public virtual CPTform CPTformId { get; set; }
        [ForeignKey("EmployementAgreementId")]
        public virtual EmployementAgreement EmploymentAgreementId { get; set; }
        [ForeignKey("EmployerId")]
        public virtual Employer EmployerId { get; set; }
        [ForeignKey("LearningObjectiveId")]
        public virtual LearningObjective LearningObjectiveId { get; set; }
        [ForeignKey("UserId")]
        public virtual User UserId { get; set; }
        public string Major { get; set; }
        public string Degree { get; set; }
        public string Concentration { get; set; }
        public int semesterHoursEarned { get; set; }
        public decimal majorGPA { get; set; }  //maybe change to float or something smaller than decimal? 
        public DateTime expectededGraduationDate { get; set; }
        public bool isPartTime { get; set; }
        public bool isSignedByStudentApplication { get; set; }
        public DateTime dateApplicationReceivedByyDept { get; set; }
        public bool IsApplicationApprovedByDept { get; set; }
        public string reasonWhyOrWhyNotApplicationIsApprovedByDept { get; set; }
        public bool isApplicationFormSignedByInstructor { get; set; }
        public DateTime dataInstructorSignedApplicationForm { get; set; }
        public bool IsApplicationSignedByDeptHead { get; set; }
        public DateTime dateApplicationsignedByDeptHead { get; set; }
        public bool isApplicationSignedByDean { get; set; }
        public DateTime dateApplicationSignedByDean { get; set; }
        public enum semesterOfInternship { fall, spring, summer }
        public bool isSignedByAcademicAdvisor { get; set; }
        public DateTime dataSignedByAcademicAdvisor { get; set; }
        public bool isSignedBySupervisorUponCompletion { get; set; }
        public DateTime dataSupervisorSignedUponCompletion { get; set; }

    }
}