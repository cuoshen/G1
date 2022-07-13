using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace G1
{
    [Serializable]
    class Meal
    {
        [SerializeField]
        private string name;
        public string Name => name;

        [SerializeField]
        private List<IngredientContainer> ingredientContainers;

        private List<IngredientCollection> ingredients;
        public ICollection<IngredientCollection> Ingredients => ingredients;

        public void MapIngredients()
        {
            ingredients = new List<IngredientCollection>();
            foreach (IngredientContainer container in ingredientContainers)
            {
                ingredients.Add(new IngredientCollection(container));
            }
        }

        public Meal()
        {
            ingredients = new List<IngredientCollection>();
            name = "Invalid";
        }

        public Meal(string name, List<IngredientCollection> ingredients)
        {
            this.name = name;
            this.ingredients = ingredients;
            MapIngredients();
        }
    }
}
