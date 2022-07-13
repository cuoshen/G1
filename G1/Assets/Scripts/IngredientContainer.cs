using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace G1
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/IngredientContainer", order = 3)]
    class IngredientContainer : ScriptableObject
    {
        public List<Ingredient> Content;
    }
}
