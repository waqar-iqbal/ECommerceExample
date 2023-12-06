using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using VictorianPlumming.ECommerce.Api.Services;
using VictorianPlumming.ECommerce.Api.dto;

namespace VictorianPlumming.ECommerce.Api
{
    [ApiController]
    [System.Web.Http.Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderSaveService _orderSaveService;

        public OrderController(IOrderSaveService orderSaveService)
        {
            _orderSaveService = orderSaveService;
        }

        [System.Web.Http.HttpPost()]
        public IActionResult Index(Order order)
        {
            try
            {
                _orderSaveService.SaveOrder(order);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }
    }
}