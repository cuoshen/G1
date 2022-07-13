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
        private IngredientContainer ingredientContainer;

        private IngredientCollection ingredients;
        public IngredientCollection Ingredients => ingredients;

        public void MapIngredients()
        {
            ingredients = new IngredientCollection(ingredientContainer);
        }

        public Meal()
        {
            name = "Invalid";
        }

        public Meal(string name, IngredientCollection ingredients)
        {
            this.name = name;
            this.ingredients = ingredients;
            MapIngredients();
        }
    }
}
