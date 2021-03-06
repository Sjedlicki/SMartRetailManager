﻿using SMartDesktopUI.Library.Models;
using System.Threading.Tasks;

namespace SMartDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
        Task GetLoggedInUserInfo(string token);
    }
}