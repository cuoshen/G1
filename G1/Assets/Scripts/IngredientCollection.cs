using System;
using System.Linq;
using System.Collections.Generic;

namespace G1
{
    class IngredientCollection : IEquatable<IngredientCollection>
    {
        private Dictionary<Ingredient, int> ingredientCount = new Dictionary<Ingredient, int>();

        public IngredientCollection(IngredientContainer container)
        {
            foreach (Ingredient ingredient in container.Content)
            {
                if (ingredientCount.ContainsKey(ingredient))
                {
                    ingredientCount[ingredient]++;
                }
                else
                {
                    ingredientCount.Add(ingredient, 1);
                }
            }
        }

        public IngredientCollection()
        {
        }

        public void Clear()
        {
            ingredientCount.Clear();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            if (ingredientCount.ContainsKey(ingredient))
            {
                ingredientCount[ingredient]++;
            }
            else
            {
                ingredientCount.Add(ingredient, 1);
            }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as IngredientCollection);
        }

        public bool Equals(IngredientCollection other)
        {
            if (this.ingredientCount.Count != other.ingredientCount.Count)
            {
                return false;
            }
            if (this.ingredientCount.Keys.Except(other.ingredientCount.Keys).Any())
                return false;
            if (other.ingredientCount.Keys.Except(this.ingredientCount.Keys).Any())
                return false;
            foreach (var pair in this.ingredientCount)
                if (pair.Value != other.ingredientCount[pair.Key])
                    return false;
            return true;
        }

        public static bool operator ==(IngredientCollection lhs, IngredientCollection rhs)
        {
            if (lhs is null)
            {
                if (rhs is null)
                {
                    return true;
                }

                // Only the left side is null.
                return false;
            }
            // Equals handles case of null on right side.
            return lhs.Equals(rhs);
        }

        public static bool operator !=(IngredientCollection lhs, IngredientCollection rhs)
        {
            return !(lhs == rhs);
        }

        public override int GetHashCode()
        {
            // Constant because equals tests mutable member.
            // This will give poor hash performance, but will prevent bugs.
            return ingredientCount.GetHashCode();
        }
    }
}
