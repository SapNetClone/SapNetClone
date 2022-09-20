using SapNetClone.Application.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapNetClone.Application.Features.User.GetAllUser
{
    public class GetAllUserQueryResponse 
    {
        public List<ListUserVM> UserVMs { get; set; }
    }
}
