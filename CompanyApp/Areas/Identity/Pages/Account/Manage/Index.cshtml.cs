#nullable disable

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using CompanyApp.Data;
using CompanyApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CompanyApp.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }


        public string Username { get; set; }
        public string Department { get; set; }
        public string Project { get; set; }


        [TempData]
        public string StatusMessage { get; set; }


        [BindProperty]
        public InputModel Input { get; set; }


        public class InputModel
        {

            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
            [Display(Name = "Surname")]
            public string Surname { get; set; }
            [Display(Name = "Sex")]
            public SexTypes? Sex { get; set; }
            [Display(Name = "Status of education")]
            public string StatusOfEducation { get; set; }
            [Display(Name = "Date of Birth")]
            public DateTime DateOfBirth { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);

            Username = userName;
            if (user.DepartmentId != null)
            {
                Department = _context.Departments.Where(x => x.Id == user.DepartmentId).FirstOrDefault().Name;
            }
            if (user.ProjectId != null)
            {
                Project = _context.Projects.Where(x => x.Id == user.ProjectId).FirstOrDefault().Name;
            }

            Input = new InputModel
            {
                PhoneNumber = await _userManager.GetPhoneNumberAsync(user),
                Surname = user.Surname,
                Sex = user.Sex,
                StatusOfEducation = user.StatusOfEducation,
                DateOfBirth = user.DateOfBirth,
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }
            else
            {
                user.Surname = Input.Surname;
                user.PhoneNumber = Input.PhoneNumber;
                user.Sex = Input.Sex;
                user.StatusOfEducation = Input.StatusOfEducation;
                user.DateOfBirth = Input.DateOfBirth;
            }

            var result = await _userManager.UpdateAsync(user);

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
