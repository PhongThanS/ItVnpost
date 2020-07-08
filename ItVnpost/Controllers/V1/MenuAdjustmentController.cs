using System.Collections.Generic;
using AutoMapper;
using ItVnpost.Models;
using ItVnpost.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ItVnpost.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    //[Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "MenuAdjustment")]
    public class MenuAdjustmentController : BaseController
    {
        public MenuAdjustmentController(IUnitOfWork unitOfWork, IMapper mapper, SignInManager<AppUser> signInManager) : base(unitOfWork, mapper, signInManager)
        {
        }

        /// <summary>
        /// Lấy tất cả dữ liệu trên thanh menu
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            foreach (MenuAdjustment menuAdjustment in _unitOfWork.MenuAdjustment.GetAll())
            {
                keyValuePairs.Add(menuAdjustment.Property, menuAdjustment.Value);
            }
            return Ok(keyValuePairs);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public IActionResult Post()
        {
            return Ok();
        }
    }
}