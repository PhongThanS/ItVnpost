using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ItVnpost.Models;
using ItVnpost.Repository.IRepository;
using ItVnpost.Utility.App;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace ItVnpost.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    //[Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "User")]
    public class UserController : BaseController
    {
        private readonly AppSettings _appSettings;
        public UserController(IUnitOfWork unitOfWork, IMapper mapper, SignInManager<AppUser> signInManager, IOptions<AppSettings> appSettings) : base(unitOfWork, mapper, signInManager)
        {
            _appSettings = appSettings.Value;
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
        public async Task<IActionResult> Option([FromQuery] string username = "", [FromQuery] string password = "", [FromQuery] bool rememberMe = true)
        {
            if (username == "" || password == "")
            {
                return BadRequest(new { success = false, message = "Tài khoản hoặc mật khẩu không được để trống" });
            }
            var result = await _signInManager.PasswordSignInAsync(username, password, rememberMe, false);
            if (result.Succeeded)
            {
                try
                {
                    AppUser user = _unitOfWork.AppUser.GetAll(filter: u => u.UserName == username).ToList()[0];
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
                    var tokenDescription = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                        }),
                        Expires = DateTime.UtcNow.AddDays(7),
                        SigningCredentials = new SigningCredentials
                        (new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var token = tokenHandler.CreateToken(tokenDescription);
                    user.Token = tokenHandler.WriteToken(token);
                    return Ok(new { success = true, message = "Đăng nhập thành công", appuser = user });
                }
                catch
                {
                    return Ok(new { success = false, message = "Đã có lỗi trong server" });
                }
            }
            else
            {
                return BadRequest(new { success = false, message = "Đăng nhập thất bại" });
            }
        }
    }
}
