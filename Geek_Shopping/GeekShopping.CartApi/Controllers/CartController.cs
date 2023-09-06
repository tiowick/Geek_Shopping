using GeekShopping.CartApi.Data.ValueObjects;
using GeekShopping.CartApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.CartApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CartController : ControllerBase
    {
        private ICartRepostory _repository;

        public CartController(ICartRepostory repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }

        [HttpGet("find-cart/{id}")]
        public async Task<ActionResult<CartDTO>> FindById(string userId)
        {
            var cart = await _repository.FindCartByUserId(userId);
            if (cart == null) return NotFound();
            return Ok(cart);
        }

        [HttpPost("add-cart")]
        public async Task<ActionResult<CartDTO>> AddCart(CartDTO Dto)
        {
            var cart = await _repository.SaveOrUpdateCart(Dto);
            if (cart == null) return NotFound();
            return Ok(cart);
        }
        [HttpPut("update-cart")]
        public async Task<ActionResult<CartDTO>> UpdateCart(CartDTO Dto)
        {
            var cart = await _repository.SaveOrUpdateCart(Dto);
            if (cart == null) return NotFound();
            return Ok(cart);
        }
        [HttpDelete("remove-cart/{id}")]
        public async Task<ActionResult<CartDTO>> RemoveCart(int id)
        {
            var status = await _repository.RemoveFromCart(id);
            if (!status) return BadRequest();
            return Ok();
        }

        [HttpPost("apply-cupom")]
        public async Task<ActionResult<CartDTO>> ApplyCupom(CartDTO Dto)
        {
            var status = await _repository.ApplyCupom(Dto.CartHeader.UserId, Dto.CartHeader.CupomCode);
            if (!status) return NotFound();
            return Ok(status);
        }

        [HttpPost("remove-cupom/{userId}")]
        public async Task<ActionResult<CartDTO>> RemoveCupom(string userId)
        {
            var status = await _repository.RemoveCupom(userId);
            if (!status) return NotFound();
            return Ok(status);
        }


    }
}

