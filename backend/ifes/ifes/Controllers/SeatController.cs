using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ifes.Api.Base;
using ifes.Contracts.Commands.Seats;
using ifes.Contracts.Queries.Seats;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ifes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : ApiControllerBase {
        public SeatController(IMediator mediator) : base(mediator) {
        }

        [HttpGet]
        public async Task<IActionResult> GetPlaneSeats(Guid planeId) {
            return await ExecuteRequest(new GetPlaneSeatsQuery { PlaneId = planeId});
        }
        [HttpPut]
        public async Task<IActionResult> SwitchSeats([FromBody] SwitchSeatsCommand switchSeats) {
            return await ExecuteRequest(switchSeats);
        }
    }
}