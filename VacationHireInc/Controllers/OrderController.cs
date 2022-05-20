using Microsoft.AspNetCore.Mvc;
using VacationHireInc.Core.Api;
using VacationHireInc.Core.Domain;

namespace VacationHireInc.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IOrderService _orderService;

        public OrderController(ILogger<OrderController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var orders = await _orderService.Get();
            return Ok(orders);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateOrderRequest request)
        {
            var result = await _orderService.Create(request);
            return Ok(result);
        }

        [HttpPatch, Route("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody]UpdateOrderRequest request)
        {
            var order = await _orderService.GetById(id);

            if (order == null)
            {
                return NotFound();
            }

            request.Id = order.Id;
            var result = await _orderService.Update(request);
            return Ok(result);
        }
    }
}