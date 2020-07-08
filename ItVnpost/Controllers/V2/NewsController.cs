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
        /// Lấy các bài báo
        /// </summary>
        /// <param name="menuId">Đưa vào menu Id của 1 loại tin tức, đây là phần bắt buộc phải có để xác định kiểu hiển thị</param>
        /// <param name="latestArticles">Option lấy theo top những bài báo mới nhất</param>
        /// <param name="mostViewArticle">Option lấy theo top những bài báo nhiều view nhất</param>
        /// <param name="numberSkip">Số lượng bài báo được lấy đầu tiên sẽ bỏ qua</param>
        /// <param name="numberTake">Sô lượng bài báo lấy</param>
        /// <remarks>
        /// Chú ý:
        /// 
        ///     Nếu không có option nào, sẽ lấy ra tất cả các bài báo
        ///     khi chọn các option thì phải có dữ liệu cho numberTake
        /// </remarks>
        /// <returns></returns>
        [HttpGet("{menuId}")]
        public IActionResult Get(int menuId, [FromQuery] bool latestArticles = false, [FromQuery] bool mostViewArticle = false,
            [FromQuery] int numberSkip = 0, [FromQuery] int numberTake = 0)
        {
            if (latestArticles)
            {
                return Ok(_unitOfWork.News.GetAll(
                    filter: x => x.IsHidden == false && x.MenuId == menuId,
                    orderBy: x => x.OrderByDescending(x => x.DateCreated)).Skip(numberSkip).Take(numberTake).Select(n => _mapper.Map<NewsDto>(n)).ToList());
            }
            else if (mostViewArticle)
            {
                return Ok(_unitOfWork.News.GetAll(
                    filter: x => x.IsHidden == false && x.MenuId == menuId,
                    orderBy: x => x.OrderByDescending(x => x.ViewCount)).Skip(numberSkip).Take(numberTake).Select(n => _mapper.Map<NewsDto>(n)).ToList());
            }
            else
            {
                return Ok(_unitOfWork.News.GetAll(
                       filter: x => x.IsHidden == false && x.MenuId == menuId,
                       orderBy: x => x.OrderByDescending(x => x.DateCreated)).Select(n => _mapper.Map<NewsDto>(n)).ToList());
            }
        }
    }
}
