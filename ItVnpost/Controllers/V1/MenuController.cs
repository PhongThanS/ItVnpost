using System.Linq;
using AutoMapper;
using ItVnpost.Models;
using ItVnpost.Models.Dtos;
using ItVnpost.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ItVnpost.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    //[Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Menu")]
    public class MenuController : BaseController
    {
        public MenuController(IUnitOfWork unitOfWork, IMapper mapper, SignInManager<AppUser> signInManager) : base(unitOfWork, mapper, signInManager)
        {
        }

        /// <summary>
        /// Lấy tất cả dữ liệu thanh menu
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_unitOfWork.Menu.GetAll(
                filter: m => m.IsHidden == false && m.IsDisplayHome == true,
                orderBy: x => x.OrderBy(me => me.OrderPosition)).ToList());
        }

    }
}