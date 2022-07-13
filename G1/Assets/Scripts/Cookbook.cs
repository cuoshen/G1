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
        private Dictionary<IngredientCollection, Meal> ingredientsToMeal = new Dictionary<IngredientCollection, Meal>();

        public void InitializeMappings()
        {
            foreach(Meal meal in meals)
            {
                meal.MapIngredients();
                foreach (IngredientCollection ingredient in meal.Ingredients)
                {
                    ingredientsToMeal.Add(ingredient, meal);
                }
            }

            Debug.Log("Mappings initialized in cookbook");
        }

        public Meal MealFromIngredients(IngredientCollection ingredients)
        {
            if (ingredientsToMeal.ContainsKey(ingredients))
            {
                return ingredientsToMeal[ingredients];
            }
            else
            {
                return new Meal();  // Invalid
            }
        }
    }
}
