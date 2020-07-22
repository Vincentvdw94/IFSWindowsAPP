using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ifes.Api.Base;
using ifes.Contracts.Commands.Foods;
using ifes.Contracts.Queries.Foods;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ifes.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ApiControllerBase {
        public FoodController(IMediator mediator) : base(mediator) {
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddFoodCommand addFoodCommand) {
            if (null == addFoodCommand) return BadRequest();
            return await ExecuteRequest(addFoodCommand);
        }
        [HttpGet]
        public async Task<IActionResult> Get() {
            return await ExecuteRequest(new GetFoodsQuery());
        }
        [HttpPut]
        public async Task<IActionResult> Put() {
            return await ExecuteRequest(null);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete() {
            return await ExecuteRequest(null);
        }


    }
}
