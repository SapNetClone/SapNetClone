using MediatR;
using Microsoft.EntityFrameworkCore;
using SapNetClone.Application.Abstract.Repositories.UsersRepository;
using SapNetClone.Application.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapNetClone.Application.Features.User.GetAllUser
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQueryRequest, GetAllUserQueryResponse>
    {
        readonly IUserReadRepository _userReadRepository;

        public GetAllUserQueryHandler(IUserReadRepository userReadRepository)
        {
            _userReadRepository = userReadRepository;
        }
        public async Task<GetAllUserQueryResponse> Handle(GetAllUserQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _userReadRepository.GetAll().ToListAsync();
            var userVmList = new List<ListUserVM>();
            foreach (var userData in data)
            {
                ListUserVM userVM = new()
                {
                    Name = userData.Name,
                    Password = userData.Password
                };
                userVmList.Add(userVM);
            }
            GetAllUserQueryResponse response =  new GetAllUserQueryResponse()
            {
                UserVMs = userVmList
            };
            return response;
        }
    }
}
