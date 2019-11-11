using Abp.Application.Services;
using CloudAlliance.MTChat.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CloudAlliance.MTChat
{
    public interface IChatAppService : IApplicationService
    {
        Task SendMessageAll(MessageDto message);

    }
}
