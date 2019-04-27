using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModulSchool.BusinessLogic;
using ModulSchool.Models;

namespace ModulSchool.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly GetUsersInfoRequestHandler _getUsersInfoRequestHandler;
		public UsersController(GetUsersInfoRequestHandler getUsersInfoRequestHandler)
		{
		_getUsersInfoRequestHandler = getUsersInfoRequestHandler;
		}

		[HttpGet("{id}")]
		public Task<User> GetUserInfo(Guid id)
		{
		return _getUsersInfoRequestHandler.HandleAsync(id);
		}
    }
}
