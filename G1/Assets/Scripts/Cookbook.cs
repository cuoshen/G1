using System;
using System.Collections.Generic;
using UnityEngine;

namespace G1
{
    /// <summary>
    /// Basically serves as a big dictionary which maps collections of ingredients to products
    /// </summary>
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Cookbook", order = 1)]
    class Cookbook : ScriptableObject
    {
        [SerializeField]
        private List<Meal> meals;
        private Dictionary<IngredientCollection, Meal> ingredientsToMeal;

        public void InitializeMappings()
        {
            foreach(Meal meal in meals)
            {
                foreach (IngredientCollection ingredient in meal.Ingredients)
                {
                    ingredientsToMeal.Add(ingredient, meal);
                }
            }
        }

        public Meal FromIngredients(IngredientCollection ingredients)
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
