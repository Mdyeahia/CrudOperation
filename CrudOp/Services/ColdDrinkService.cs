using CrudOp.Models;
using CrudOp.Models.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOp.Services
{
    public class ColdDrinkservice : DrinkRepository<ColdDrink>
    {

        readonly dbAkijFoodContext context;

        public ColdDrinkservice(dbAkijFoodContext context)
        {
            this.context = context;
        }
        public IEnumerable<ColdDrink> GetAllColdDrink()
        {

            var vps = context.ColdDrinks.Where(a => a.numQuantity < 500).ToList();
            foreach (var vp in vps)
                context.ColdDrinks.Remove(vp);
            context.SaveChanges();
            return context.ColdDrinks.ToList();
        }
        public ColdDrink GetColdDrinkById(int Id)
        {
            //var context=new dbAkijFoodcontext();
            return context.ColdDrinks.Find(Id);
        }
        public void SaveColdDrink(ColdDrink entity)
        {

            context.ColdDrinks.Add(entity);
            context.SaveChanges();
        }
        public void UpdateColdDrink(ColdDrink coldDrink, ColdDrink entity)
        {
            coldDrink.strColdDrinksName = entity.strColdDrinksName;
            coldDrink.numQuantity = entity.numQuantity;
            coldDrink.numUnitPrice = entity.numUnitPrice;

            context.Entry(coldDrink).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            context.SaveChanges();
        }
        public void DeleteColdDrink(int Id)
        {
            //var context=new dbAkijFoodcontext();

            var coldDrink = context.ColdDrinks.Find(Id);
            context.ColdDrinks.Remove(coldDrink);

            context.SaveChanges();
        }
        public int GetTotalPrice()
        {
            return (int)context.ColdDrinks.Sum(row => row.numUnitPrice);
        }
        public List<string> GetProductName()
        {

            return context.ColdDrinks.AsEnumerable().Select(row => row.strColdDrinksName).ToArray().ToList();
        }
    }
}
