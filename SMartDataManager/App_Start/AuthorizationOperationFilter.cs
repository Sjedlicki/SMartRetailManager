using Swashbuckle.Swagger;
using System.Collections.Generic;
using System.Web.Http.Description;

namespace SMartDataManager.App_Start
{
    public class AuthorizationOperationFilter : IOperationFilter
    {
        // Adding a parameter to every operation
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if(operation.parameters == null)
            {
                operation.parameters = new List<Parameter>();
            }

            operation.parameters.Add(new Parameter
            {
                name = "Authorization",
                @in = "header",
                description = "access token", // documentaion for it
                required = false,
                type = "string"
            });
        }
    }
}