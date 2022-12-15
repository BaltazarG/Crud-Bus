using Crud_Bus.Models;
using Crud_Bus.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud_Bus.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarsController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddCar(CarModel model)
        {
            await _carRepository.AddCar(model);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetQueue()
        {
            _carRepository.GetQueue();

            return Ok();
        }
    }
}
