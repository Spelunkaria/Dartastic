using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Dartastic
{
	class Dartastic : Mod
	{
		public Dartastic()
		{
			Properties = new ModProperties(){
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

		public override void AddRecipes(){
			 // Removing Recipes.
            List<Recipe> rec = Main.recipe.ToList();
            int numberRecipesRemoved = 0;
            // The Recipes to remove.
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.PoisonDart);
			numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.CrystalDart);
			numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.IchorDart);
			numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.CursedDart);
			Main.recipe = rec.ToArray();
            Array.Resize(ref Main.recipe, Recipe.maxRecipes);
            Recipe.numRecipes -= numberRecipesRemoved;
		}
	}
}