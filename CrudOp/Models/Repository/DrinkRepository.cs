using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOp.Models.Repository
{
    public interface DrinkRepository<DrinkEntity>
    {
        IEnumerable<DrinkEntity> GetAllColdDrink();
        DrinkEntity GetColdDrinkById(int Id);
        void SaveColdDrink(DrinkEntity entity);
        void UpdateColdDrink(ColdDrink coldDrink, DrinkEntity entity);
        void DeleteColdDrink(int Id);
        int GetTotalPrice();
        List<string> GetProductName();
    }
}
