using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ItVnpost.Models;
using ItVnpost.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ItVnpost.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    //[Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "User")]
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
        [HttpOptions]
        public async Task<IActionResult> Post([FromQuery] string username = "", [FromQuery] string password = "", [FromQuery] bool rememberMe = true)
        {
            if (username == "" || password == "")
            {
                return Ok(new { success = false, message = "Tài khoản hoặc mật khẩu không được để trống" });
            }
            var result = await _signInManager.PasswordSignInAsync(username, password, rememberMe, false);
            if (result.Succeeded)
            {
                return Ok(new { success = true, message = "Đăng nhập thành công" });
            }
            else
            {
                return Ok(new { success = false, message = "Đăng nhập thất bại" });
            }
        }
    }
}
