using System.Linq;
using AutoMapper;
using ItVnpost.Models;
using ItVnpost.Models.Dtos;
using ItVnpost.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ItVnpost.Controllers.V2
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("2.0")]
    //[Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "News")]
    public class NewsController : ControllerBase
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;
        public NewsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        /// <summary>
        /// Lấy tất cả dữ liệu của phần news 1
        /// </summary>
        /// <param name="id">Đưa vào id của danh mục</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(_unitOfWork.News.GetAll(x => x.IsHidden == false && x.MenuId == id).OrderByDescending(x => x.ViewCount).Take(4).Select(n => _mapper.Map<NewsDto>(n)).ToList());
        }
    }
}
