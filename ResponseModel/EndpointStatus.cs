using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ResponseModel
{
    public class EndpointStatus : IEndpointStatus
    {
        public IResult Ok(object obj, string message = null)
        {
            return Results.Ok(new ResponseModel(HttpStatusCode.OK,
                                                message == "" ? DefaultMessages.MessageOk : message,
                                                obj));
        }
        public IResult Created(object obj, string message = null)
        {
            return Results.Ok(new ResponseModel(HttpStatusCode.Created,
                                                message == "" ? DefaultMessages.MessageCreated : message,
                                                obj));
        }
        public IResult NoContent(object obj, string message = null)
        {
            return Results.Ok(new ResponseModel(HttpStatusCode.NoContent,
                                                message == "" ? DefaultMessages.MessageNoContent : message,
                                                obj));
        }
        public IResult BadRequest(object obj, string message = null)
        {
            return Results.BadRequest(new ResponseModel(HttpStatusCode.BadRequest,
                                                message == "" ? DefaultMessages.MessageBadRequest : message,
                                                obj));
        }
        public IResult NotFound(object obj, string message = null)
        {
            return Results.NotFound(new ResponseModel(HttpStatusCode.NotFound,
                                                message == "" ? DefaultMessages.MessageNotFound : message,
                                                obj));
        }
        public IResult InternalServerError(object obj, string message = null, string detail = null)
        {
            var problem = new ProblemDetails
            {
                Title = message == "" ? DefaultMessages.MessageInternalServerError : message,
                Status = 500,
                Detail = detail == "" ? "Ocorreu erro interno no servidor. Contate equipe tecnica" : message,
            };
            return Results.Problem(problem);
        }
    }

    public record DefaultMessages
    {
        public static string MessageOk { get; } = "Requisição Ok.";
        public static string MessageCreated { get; } = "Requisição Criada.";
        public static string MessageNoContent { get; } = "Requisição ok sem conteúdo.";
        public static string MessageBadRequest { get; } = "Requisição inválida.";
        public static string MessageNotFound { get; } = "Requisição não encontrada.";
        public static string MessageInternalServerError { get; } = "Erro no servidor.";
    }
}
