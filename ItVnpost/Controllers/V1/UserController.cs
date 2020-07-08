using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ItVnpost.Models;
using ItVnpost.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ItVnpost.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [Authorize]
    //[Route("api/[controller]")]
    //[ApiExplorerSettings(GroupName = "User")]
    [ApiController]
    public class UserController : BaseController
    {
        public UserController(IUnitOfWork unitOfWork, IMapper mapper, SignInManager<AppUser> signInManager) : base(unitOfWork, mapper, signInManager)
        {
        }

        /// <summary>
        /// Lấy dữ liệu người dùng hiện tại trên server
        /// </summary>
        /// <param name="checkSignIn">Kiểm tra người dùng có đăng nhập</param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Get([FromQuery] bool checkSignIn)
        {
            if (checkSignIn)
            {
                return Ok(_signInManager.IsSignedIn(User));
            }
            else
            {
                return Ok(User);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpOptions]
        public IActionResult Post([FromQuery] string username = "", [FromQuery] string password = "", [FromQuery] bool rememberMe = true)
        {
            if (username == "" || password == "")
            {
                return BadRequest(new { success = false, message = "Tài khoản hoặc mật khẩu không được để trống" });
            }
            AppUser user = _unitOfWork.AppUser.Authenticate(username, password);

            if (user == null)
            {
                return BadRequest(new { success = false, message = "Tài khoản hoặc mật khẩu không đúng" });
            }
            return Ok(new { success = true, message = user });
        }
    }
}
