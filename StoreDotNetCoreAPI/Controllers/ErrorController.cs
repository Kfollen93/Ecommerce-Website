using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace StoreDotNetCoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ErrorController : ControllerBase
    {
        [HttpGet("not-found")]
        public ActionResult GetNotFound() => NotFound();

        [HttpGet("bad-request")]
        public ActionResult GetBadRequest() => BadRequest(new ProblemDetails{Title = "This is a bad request"});

        [HttpGet("unauthorized")]
        public ActionResult GetUnauthorized() => Unauthorized();

        [HttpGet("validation-error")]
        public ActionResult GetValidationError()
        {
            ModelState.AddModelError("Problem 1", "First error.");
            ModelState.AddModelError("Problem 2", "Second error.");
            return ValidationProblem();
        }

        [HttpGet("server-error")]
        public ActionResult GetServerError() => throw new System.Exception("Server error");

    }
}
