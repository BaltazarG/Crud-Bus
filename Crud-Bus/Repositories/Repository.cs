using Crud_Bus.Context;

namespace Crud_Bus.Repositories
{
    public class Repository
    {
        internal readonly CarContext _carContext;

        public Repository(CarContext carContext)
        {
            _carContext = carContext;
        }
    }
}
