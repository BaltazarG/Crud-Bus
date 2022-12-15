using Crud_Bus.Context;
using Crud_Bus.Entities;
using Crud_Bus.Models;
using Crud_Bus.Services;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Crud_Bus.Repositories
{
    public class CarRepository : Repository, ICarRepository
    {
        private readonly AzureBusService _azureBusService;
        public CarRepository(CarContext carContext, AzureBusService azureBusService) : base(carContext)
        {
            _azureBusService = azureBusService;
        }

        public async Task AddCar(CarModel model)
        {
            _carContext.Cars.Add(new Car()
            {
                Color = model.Color,
                Name = model.Name
            });

            _carContext.SaveChanges();

            //await _azureBusService.SendMessageAsync(model);


        }

        public async void GetQueue()
        {
            var jsonstring = await _azureBusService.GetQueueAz();

            if (jsonstring == null)
                return;

            dynamic json = JsonConvert.DeserializeObject(jsonstring);

            _carContext.CarsDone.Add(new CarDone()
            {
                Color = json.Color,
                Name = json.Name
            });

            _carContext.SaveChanges();

        }
    }
}
