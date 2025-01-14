using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class EmployeeReferralController : BaseApiController
    {
        private readonly DataContext _context;
        public EmployeeReferralController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetEmployeeReferralById(int id)
        {
            var employeeReferral = await _context.EmployeeReferral.FindAsync(id);
            if(employeeReferral == null)
            {
                return NotFound();
            }
            return Ok(employeeReferral);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllEmployeeReferrals()
        {
            var employeeReferrals = await _context.EmployeeReferral.ToListAsync();
            return Ok(employeeReferrals);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterEmployeeReferral(EmployeeReferral employeeReferral)
        {
            int id = employeeReferral.Id;
            if (employeeReferral.Id == 0)
            {
                employeeReferral.CreatedOn = DateTime.Now;
                employeeReferral.ModifiedOn = DateTime.Now;
                _context.Add(employeeReferral);
                await _context.SaveChangesAsync();
                id = employeeReferral.Id;
            }
            else
            {
                return BadRequest();
            }

            return Ok(id);
        }
        
        [HttpPut("Update")]
        public async Task<IActionResult> UpdateEmployeeReferral(EmployeeReferral employeeReferral)
        {
            var existingEmployeeReferral = await _context.EmployeeReferral.FindAsync(employeeReferral.Id);
            if(existingEmployeeReferral == null)
            {
                return NotFound();
            }
            existingEmployeeReferral.CreatedOn = employeeReferral.CreatedOn;
            existingEmployeeReferral.CreatedBy = employeeReferral.CreatedBy;
            existingEmployeeReferral.ModifiedBy = employeeReferral.ModifiedBy;
            existingEmployeeReferral.ModifiedOn = employeeReferral.ModifiedOn;
            existingEmployeeReferral.ApplicantFirstName = employeeReferral.ApplicantFirstName;
            existingEmployeeReferral.ApplicantLastName = employeeReferral.ApplicantLastName;
            existingEmployeeReferral.DateOfBirth = employeeReferral.DateOfBirth;
            existingEmployeeReferral.Phone = employeeReferral.Phone;
            existingEmployeeReferral.Email = employeeReferral.Email;
            existingEmployeeReferral.ReferredPositionNameAndTitle = employeeReferral.ReferredPositionNameAndTitle;
            existingEmployeeReferral.ReferrerFirstName = employeeReferral.ReferrerFirstName;
            existingEmployeeReferral.ReferrerLastName = employeeReferral.ReferrerLastName;
            existingEmployeeReferral.ReferrerTitle = employeeReferral.ReferrerTitle;
            existingEmployeeReferral.ReferrerDepartment = employeeReferral.ReferrerDepartment;
            existingEmployeeReferral.ReferrerEmail = employeeReferral.ReferrerEmail;
            existingEmployeeReferral.ReferrerPhone = employeeReferral.ReferrerPhone;
            existingEmployeeReferral.AddressLine1 = employeeReferral.AddressLine1;
            existingEmployeeReferral.AddressLine2 = employeeReferral.AddressLine2;
            existingEmployeeReferral.City = employeeReferral.City;
            existingEmployeeReferral.Region = employeeReferral.Region;
            existingEmployeeReferral.ZipCode = employeeReferral.ZipCode;
            existingEmployeeReferral.Country = employeeReferral.Country;
            existingEmployeeReferral.SignatureUrl = employeeReferral.SignatureUrl;

            _context.Update(existingEmployeeReferral);
            await _context.SaveChangesAsync();

            return Ok(existingEmployeeReferral.Id);
        }
    }
}