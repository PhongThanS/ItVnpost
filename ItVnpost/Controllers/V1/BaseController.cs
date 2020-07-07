using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ItVnpost.Models;
using ItVnpost.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ItVnpost.Controllers.V1
{
    public abstract class BaseController : ControllerBase
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;
        protected readonly SignInManager<AppUser> _signInManager;
        public BaseController(IUnitOfWork unitOfWork, IMapper mapper, SignInManager<AppUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _signInManager = signInManager;
        }
    }
}
