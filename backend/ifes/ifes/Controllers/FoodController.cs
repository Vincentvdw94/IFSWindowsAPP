using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ifes.Api.Base;
using ifes.Contracts.Commands.Foods;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ifes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ApiControllerBase {
        public FoodController(IMediator mediator) : base(mediator) {
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Post([FromBody] AddFoodCommand addFoodCommand) {
            // Adds company to list, returns it for detail page later
            if (null == addFoodCommand) return BadRequest();
            return await ExecuteRequest(addFoodCommand);
        }
    }
}