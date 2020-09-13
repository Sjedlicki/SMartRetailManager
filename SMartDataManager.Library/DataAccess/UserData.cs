using SMartDataManager.Library.Internal.DataAccess;
using SMartDataManager.Library.Models;
using System.Collections.Generic;

namespace SMartDataManager.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new
            {
                Id = id
            };

            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookUp", p, "SMartData");

            return output;
        }
    }
}
