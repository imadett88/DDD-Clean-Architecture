using Application;
using Application.Students;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiController]
    [Route("v1")]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;   

        public StudentController() { }

        [HttpGet("students")]
        public async Task<IActionResult> GetStudents(CancellationToken cancellationToken)
        {
            var query = new GetStudentsQuery
            {

            };
            var result = await _mediator.Send(query, cancellationToken);
            return Ok(result);

        }


    }
}