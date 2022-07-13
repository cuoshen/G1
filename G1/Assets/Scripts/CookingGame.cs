using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace G1
{
    class CookingGame : MonoBehaviour
    {
        [SerializeField]
        private Cookbook cookbook;

        public Meal MakeMeal()
        {
            return new Meal();
        }
    }
}
