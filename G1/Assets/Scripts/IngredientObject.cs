using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace G1
{
    class IngredientObject : MonoBehaviour
    {
        /// <summary>
        /// Underlying ingredient
        /// </summary>
        [SerializeField]
        private Ingredient ingredient;
        public Ingredient Ingredient => ingredient;

        [SerializeField]
        private CookingGame game;

        private void OnMouseDown()
        {
            Debug.Log(ingredient.Name + " added to the pot!");
            game.CurrentCollection.AddIngredient(ingredient);
        }
    }
}
