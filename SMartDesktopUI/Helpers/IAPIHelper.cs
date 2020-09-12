using SMartDesktopUI.Models;
using System.Threading.Tasks;

namespace SMartDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
    }
}