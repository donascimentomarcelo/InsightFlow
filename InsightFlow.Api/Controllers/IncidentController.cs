using InsightFlow.Application.commands;
using InsightFlow.Application.Queries;
using InsightFlow.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InsightFlow.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncidentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public IncidentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CreateIncidentResponse>> Create([FromBody] CreateIncidentCommand command)
        {
            var response = await _mediator.Send(command, default);
            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<IncidentResponse>>> Get()
        {
            var query = new GetIncidentsQuery();
            var response = await _mediator.Send(query, default);
            return Ok(response);
        }
    }
}