using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Models.Dtos
{
    public class AppRoleDto : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
