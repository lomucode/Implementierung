using System.Linq;
using System.Threading.Tasks;
using testcsharp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace testcsharp.Controllers
{
    [Authorize]
    public class UserRoleManagementSupervisorController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserRoleManagementSupervisorController(UserManager<IdentityUser> userManager,
                                            RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        
        [Authorize(Roles = "Supervisor")]
        [HttpGet]
        public IActionResult Index()
        {
            //get all users and send to view
            var users = userManager.Users.ToList();
            return View(users);
        }
        [Authorize(Roles = "Supervisor")]
        [HttpGet]
        public async Task<IActionResult> DetailsSupervisor(string userId)
        {
            //find user by userId
            //Add UserName to ViewBag
            //get userRole of users and send to view
            var user = await userManager.FindByIdAsync(userId);

            ViewBag.UserName = user.UserName;

            var userRoles = await userManager.GetRolesAsync(user);

            return View(userRoles);
        }
        [Authorize(Roles = "Supervisor")]
        [HttpGet]
        public IActionResult AddRoleSupervisor()
        {
            return RedirectToAction(nameof(DisplayRolesSupervisor));
        }
        [Authorize(Roles = "Supervisor")]
        [HttpPost]
        public async Task<IActionResult> AddRoleSupervisor(string role)
        {
            //create new role using roleManager
            //return to displayRoles
            await roleManager.CreateAsync(new IdentityRole(role));
            return RedirectToAction(nameof(DisplayRolesSupervisor));
        }
        [Authorize(Roles = "Supervisor")]
        [HttpGet]
        public IActionResult DisplayRolesSupervisor()
        {
            //get all roles and pass to view
            var roles = roleManager.Roles.ToList();

            return View(roles);
        }
        [Authorize(Roles = "Supervisor")]
        [HttpGet]
        public IActionResult AddUserToRoleSupervisor()
        {
            //get all users
            //get all roles

            var users = userManager.Users.ToList();
            var roles = roleManager.Roles.ToList();

            ViewBag.Users = new SelectList(users, "Id", "UserName");
            ViewBag.Roles = new SelectList(roles, "Name", "Name");
            return View();
        }
        [Authorize(Roles = "Supervisor")]
        [HttpPost]
        public async Task<IActionResult> AddUserToRoleSupervisor(UserRole userRole)
        {
            //find user from userRole.UserId
            //assign role to user
            //redirect to index

            var user = await userManager.FindByIdAsync(userRole.UserId);

            await userManager.AddToRoleAsync(user, userRole.RoleName);

            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles = "Supervisor")]
        [HttpGet]
        public async Task<IActionResult> RemoveUserRoleSupervisor(string role, string userName)
        {
            //get user from userName
            //remove role of user using userManager
            //return to details with parameter userId

            var user = await userManager.FindByNameAsync(userName);

            var result = await userManager.RemoveFromRoleAsync(user, role);

            return RedirectToAction(nameof(DetailsSupervisor), new { userId = user.Id });
        }
        [Authorize(Roles = "Supervisor")]
        [HttpGet]
        public async Task<IActionResult> RemoveRoleSupervisor(string role)
        {
            //get role to delete using role Name
            //delete role using roleManager
            //redirect to displayroles

            var roleToDelete = await roleManager.FindByNameAsync(role);
            var result = await roleManager.DeleteAsync(roleToDelete);

            return RedirectToAction(nameof(DisplayRolesSupervisor));
        }
        [Authorize(Roles = "Supervisor")]
        [HttpGet]
        public IActionResult SettingsSupervisor()
        {
            return View();
        }






    }
}