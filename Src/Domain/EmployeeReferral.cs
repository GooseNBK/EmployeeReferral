using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class EmployeeReferral
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        // Applicant information
        public string ApplicantFirstName { get; set; }
        public string ApplicantLastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        // Referred position
        public string ReferredPositionNameAndTitle { get; set; }

        // Referred by
        public string ReferrerFirstName { get; set; }
        public string ReferrerLastName { get; set; }
        public string ReferrerTitle { get; set; }
        public string ReferrerDepartment { get; set; }
        public string ReferrerEmail { get; set; }
        public string ReferrerPhone { get; set; }

        // Address
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        // Signature URL
        public string SignatureUrl { get; set; }
    }
}