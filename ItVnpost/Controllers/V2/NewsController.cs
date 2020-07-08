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
        /// Lấy dữ liệu của phần news 1
        /// </summary>
        /// <param name="menuId">Đưa vào id của 1 menu</param>
        /// <param name="getTop1">Lấy bài viết mới nhất</param>
        /// <param name="getTop3AfterTop1">Lấy 3 bài viết mới nhất sau bài số 1</param>
        /// <param name="getAll">Lấy tất cả bài viết</param>
        /// <returns></returns>
        [HttpGet("{menuId}")]
        public IActionResult Get(int menuId, [FromQuery] bool getTop1, [FromQuery] bool getTop3AfterTop1, [FromQuery] bool getAll)
        {
            if (getTop1)
            {
                return Ok(_unitOfWork.News.GetAll(
                    filter: x => x.IsHidden == false && x.MenuId == menuId,
                    orderBy: x => x.OrderByDescending(x => x.DateCreated)).Take(1).Select(n => _mapper.Map<NewsDto>(n)).ToList());
            }
            else if (getTop3AfterTop1)
            {
                return Ok(_unitOfWork.News.GetAll(
                       filter: x => x.IsHidden == false && x.MenuId == menuId,
                       orderBy: x => x.OrderByDescending(x => x.DateCreated)).Skip(1).Take(3).Select(n => _mapper.Map<NewsDto>(n)).ToList());
            }
            else if (getAll)
            {
                return Ok(_unitOfWork.News.GetAll(
                       filter: x => x.IsHidden == false && x.MenuId == menuId,
                       orderBy: x => x.OrderByDescending(x => x.DateCreated)).Select(n => _mapper.Map<NewsDto>(n)).ToList());
            }
            else
            {
                return BadRequest(new { message = "Các option không được để trống" });
            }
        }
    }
}
