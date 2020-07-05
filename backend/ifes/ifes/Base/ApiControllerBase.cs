using ifes.Contracts.Dtos.Errors;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ifes.Api.Base {
    public class ApiControllerBase : ControllerBase {
        private readonly IMediator _mediator;

        public ApiControllerBase(IMediator mediator) {
            _mediator = mediator;
        }

        private IActionResult StatusCodeWithMessages(HttpStatusCode statusCode, string message) => StatusCodeWithMessages(statusCode, new[] { message });
        private IActionResult StatusCodeWithMessages(HttpStatusCode statusCode, IEnumerable<string> messages) {

            var dto = new ErrorMessageDto(statusCode, messages);
            return StatusCode(dto.StatusCode, dto);

        }


        protected async Task<IActionResult> ExecuteRequest<T>(IRequest<T> request) {
            try {




                var result = await _mediator.Send(request);
                return Ok(result);
            } catch (ValidationException ex) {
                return StatusCodeWithMessages(HttpStatusCode.BadRequest, ex.Message);
            } catch (ApplicationException ex) {
                return StatusCodeWithMessages(HttpStatusCode.NotFound, ex.Message);
            }
            //catch (UnauthorizedException ex)
            //{
            //    return StatusWithMessages(HttpStatusCode.Forbidden, ex.Message);
            //}
            //catch (DomainException ex)
            //{
            //    return StatusWithMessages(HttpStatusCode.BadRequest, ex.Message);
            //}
            catch (Exception ex) {
                return StatusCodeWithMessages(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        protected async Task<IActionResult> ExecuteRequest(IRequest request) {
            try {
                await _mediator.Send(request);
                return NoContent();
            } catch (ValidationException ex) {
                return StatusCodeWithMessages(HttpStatusCode.BadRequest, ex.Message);
            } catch (ApplicationException ex) {
                return StatusCodeWithMessages(HttpStatusCode.NotFound, ex.Message);
            }
            //catch (UnauthorizedException ex)
            //{
            //    return StatusWithMessages(HttpStatusCode.Forbidden, ex.Message);
            //}
            //catch (DomainException ex)
            //{
            //    return StatusWithMessages(HttpStatusCode.BadRequest, ex.Message);
            //}
            catch (Exception) {
                //TODO: Log exception details with Microsoft.Extensions.Logging.AzureAppServices or Application Insights?
                return StatusCodeWithMessages(HttpStatusCode.InternalServerError, "An error has occurred. Please try again, and if the problem persists, contact the Travelorama team.");
            }
        }

    }
}

