using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace G1
{
    [CreateAssetMenu(fileName = "Ingredient", menuName = "ScriptableObjects/Ingredient", order = 2)]
    class Ingredient : ScriptableObject
    {
        [SerializeField]
        private string name;
        public string Name => name;
    }
}
