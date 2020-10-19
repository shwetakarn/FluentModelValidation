using Microsoft.AspNetCore.Mvc;
using ModelValidation.Model;

namespace ModelValidation.Controllers
{
       
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        public ActionResult CreateProduct([FromBody] Product prod)
        {
            // wrong approach

            // ProductValidator obj = new ProductValidator(); // y instantiate productvalidatr cls here??
            // var temp = obj.Validate(prod); // y validate here? wrong approach , since u r breaking srp.
            // if(temp.IsValid)
            // {
            //     return Ok();
            // }
            // else{
            //     return BadRequest(temp.Errors);
            // }

            //right approach

            return Ok();
        }
    }
}