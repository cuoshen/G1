using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace G1
{
    class CookingGame : MonoBehaviour
    {
        [SerializeField]
        private Cookbook cookbook;

        public IngredientCollection CurrentCollection { get; private set; } = new IngredientCollection();

        public Meal MakeMeal()
        {
            return cookbook.MealFromIngredients(CurrentCollection);
        }

        public void ClearCollection()
        {
            CurrentCollection.Clear();
        }

        public void OnMakeMealButtonHit()
        {
            Debug.Log("Making meal...");
            Debug.Log("Made " + MakeMeal().Name);
        }

        public void Start()
        {
            cookbook.InitializeMappings();
        }
    }
}
