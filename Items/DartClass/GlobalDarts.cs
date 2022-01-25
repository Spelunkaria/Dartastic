using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic
{
        public class GlobalDarts : GlobalNPC{

                public override void NPCLoot(NPC npc){
                        
                        if(npc.type == NPCID.SkeletronHead)
                        {
                                if(Main.rand.Next(0,7) == 0){
                                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.DartClass.DartWeapons.DartPre.SpineShot>());
                                }
                        }

                        if(npc.type == NPCID.AngryBones){
                                if(Main.rand.Next(0,20) == 0){
                                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.DartClass.DartWeapons.DartPre.Trombone>());
                                }
                        }

                        if(npc.type == NPCID.AngryBonesBig){
                                if(Main.rand.Next(0,20) == 0){
                                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.DartClass.DartWeapons.DartPre.Trombone>());
                                }
                        }

                        if(npc.type == NPCID.AngryBonesBigHelmet){
                                if(Main.rand.Next(0,20) == 0){
                                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.DartClass.DartWeapons.DartPre.Trombone>());
                                }
                        }

                        if(npc.type == NPCID.AngryBonesBigMuscle){
                                if(Main.rand.Next(0,20) == 0){
                                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.DartClass.DartWeapons.DartPre.Trombone>());
                                }
                        }

                        if(npc.type == NPCID.Plantera){
                                if(Main.rand.Next(0,10) == 0){
                                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.DartClass.DartWeapons.DartHard.Fertilizer>());
                                }
                        }

                        if(npc.type == NPCID.WallofFlesh){
                                if(Main.rand.Next(0,8) == 0){
                                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.DartClass.DartAccessories.DartslingersEmblem>());
                                }
                        }

                        if(npc.type == NPCID.EyeofCthulhu){
                                if(Main.rand.Next(0,5) == 0){
                                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.DartClass.DartAccessories.DartBoard>());
                                }
                        }

                        if(npc.type == NPCID.SkeletronHead)
                        {
                                if(Main.rand.Next(0,7) == 0){
                                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.DartClass.DartAccessories.DartslingersGlove>());
                                }
                        }

                        if(npc.type == NPCID.QueenBee)
                        {
                                if(Main.rand.Next(0,7) == 0){
                                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.DartClass.DartWeapons.DartPre.Tranquilizer>());
                                }
                        }
                 }
        }
}