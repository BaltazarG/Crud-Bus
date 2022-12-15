using Crud_Bus.Models;

namespace Crud_Bus.Repositories
{
    public interface ICarRepository
    {
        public Task AddCar(CarModel model);
        public void GetQueue();
    }
}
