using Microsoft.AspNet.Identity;
using SMartDataManager.Library.DataAccess;
using SMartDataManager.Library.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SMartDataManager.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {  
        // GET api/User
        public UserModel GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();

            UserData data = new UserData();            

            return data.GetUserById(userId).FirstOrDefault();
        }
    }
}
