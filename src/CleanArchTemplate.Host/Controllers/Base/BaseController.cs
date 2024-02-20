using System.Net.Mime;
using System.Runtime.InteropServices.JavaScript;

using LonH.Shared.ApiResponses;
using LonH.Shared.Filters;

using Microsoft.AspNetCore.Mvc;

namespace CleanArchTemplate.Host.Controllers.Base;

[ApiController]
[TypeFilter(typeof(CustomValidationFilter))]
[Route("api/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[ProducesResponseType(typeof(ApiErrorResponse), StatusCodes.Status500InternalServerError)]
public abstract class BaseController : ControllerBase
{
    /// <summary>
    /// Returns an IActionResult object based on the list of errors passed as parameter.
    /// </summary>
    /// <param name="errors">List of errors to be handled.</param>
    /// <returns>An IActionResult object based on the type of errors.</returns>
    protected static IActionResult ReturnErrorResponse(List<JSType.Error> errors)
    {
        // todo: implement with Result type
        throw new NotImplementedException();
    }
}