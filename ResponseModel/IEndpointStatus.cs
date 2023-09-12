using Microsoft.AspNetCore.Http;

namespace ResponseModel
{
    public interface IEndpointStatus
    {
        IResult BadRequest(object obj, string message = null);
        IResult Created(object obj, string message = null);
        IResult InternalServerError(object obj, string message = null, string detail = null);
        IResult NoContent(object obj, string message = null);
        IResult NotFound(object obj, string message = null);
        IResult Ok(object obj, string message = null);
    }
}