using Abaya_Store.Application.DTOs.Bill;
using Abaya_Store.Application.Features.Bills.Requests.Commands;
using Abaya_Store.Application.Features.Bills.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Abaya_Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
		private readonly IMediator _mediator;

		public BillController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<BillController>
		[HttpGet]
        public async Task<ActionResult<List<BillDto>>> Get()
        {
            var bill = await _mediator.Send(new GetBillListRequest());
            return Ok(bill);
        }

        // GET api/<BillController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BillDto>> Get(int id)
        {
            var bill = await _mediator.Send(new GetBillDetailRequest { Id = id});
            return Ok(bill);
        }

        // POST api/<BillController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateBillDto createBillDto)
        {
            var command = new CreateBillCommand { BillDto = createBillDto };
            var response = await _mediator.Send(command);
            return Ok(response);

		}

        // PUT api/<BillController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateBillDto billDto)
		{
			var command = new UpdateBillCommand { UpdateBillDto = billDto };
			await _mediator.Send(command);
            return NoContent();
		}

        // DELETE api/<BillController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
		{
			var command = new DeleteBillCommand {Id = id};
			await _mediator.Send(command);
			return NoContent();
		}
    }
}
