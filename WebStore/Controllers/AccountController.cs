using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities.Identity;

namespace WebStore.Controllers
{
    public class AccountController : Controller
    {
        public readonly UserManager<User> _UserManager;
        public readonly RoleManager<Role> _RoleManager;

        public AccountController(UserManager<User> UserManager, RoleManager<Role> RoleManager)
        {
            _UserManager = UserManager;
            _RoleManager = RoleManager;
        }
    }
}
