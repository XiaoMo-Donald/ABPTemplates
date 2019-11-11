using Abp.Dependency;
using Abp.Runtime.Session;
using Castle.Core.Logging;
using CloudAlliance.MTChat.Dto;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CloudAlliance.MTChat
{
    public class MTChatHub : Hub, ITransientDependency
    {

        public IAbpSession AbpSession { get; set; }

        public ILogger Logger { get; set; }

        public MTChatHub()
        {
            AbpSession = NullAbpSession.Instance;
            Logger = NullLogger.Instance;
        }


        /// <summary>
        /// 重写链接方法
        /// </summary>
        /// <returns></returns>
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }


        /// <summary>
        /// 重写离线方法
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }


        public async Task SendMessage(MessageDto message)
        {
            await Clients.User("").SendAsync("ReceiveMessage", new MessageDto
            {
                Message=$"我收到了你的信息:{message.Message}，我还知道了你的Id:{Context.ConnectionId}，当然啦，从服务器我还知道了你的昵称：{message.Nickname}"
            });

        }


        public async Task SendMessageAll(MessageDto message)
        {
            await Clients.All.SendAsync("ReceiveMessageAll", new MessageDto
            {
                Message = $"Hi,{message.Nickname},你好啊，我收到了你的信息：{message.Message}，当然啦，从服务器我还知道了你的昵称：{message.Nickname}，我还知道了你的Id：{Context.ConnectionId}，"

            });

        } 
    }

  
}
