using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ifes.Api.Base;
using ifes.Contracts.Commands.Beverages;
using ifes.Contracts.Queries.Beverages;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ifes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeverageController : ApiControllerBase {
        public BeverageController(IMediator mediator) : base(mediator) {
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddBeverageCommand addBeverageCommand) {
            if (null == addBeverageCommand) return BadRequest();
            return await ExecuteRequest(addBeverageCommand);
        }
        [HttpGet]
        public async Task<IActionResult> Get() {
            return await ExecuteRequest(new GetBeveragesQuery());
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateBeverageCommand updateBeverageCommand) {
            return await ExecuteRequest(updateBeverageCommand);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id) {
            return await ExecuteRequest(new DeleteBeverageCommand { Id = id });
        }

    }
}