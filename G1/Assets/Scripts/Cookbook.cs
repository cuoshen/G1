using System;
using System.Collections.Generic;
using UnityEngine;

namespace G1
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Cookbook", order = 1)]
    class Cookbook : ScriptableObject
    {
        [SerializeField]
        private List<Meal> meals;
        private List<IngredientCollection> ingredientsForEachMeal = new List<IngredientCollection>();

        public void InitializeMappings()
        {
            foreach(Meal meal in meals)
            {
                meal.MapIngredients();
                ingredientsForEachMeal.Add(meal.Ingredients);
            }

            Debug.Log("Mappings initialized in cookbook");
        }

        public Meal MealFromIngredients(IngredientCollection ingredients)
        {
            for (int i = 0; i < meals.Count; i++)
            {
                if (ingredientsForEachMeal[i] == ingredients)
                {
                    return meals[i];
                }
            }

            return new Meal();
        }
    }
}
