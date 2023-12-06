using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using VP_E_Commerce_Api.Services;
using VP_E_Commerce_Api.dto;

namespace VP_E_Commerce_Api.Controllers
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