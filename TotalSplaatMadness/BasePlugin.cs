using BepInEx;
using HarmonyLib;
using MTM101BaldAPI;
using MTM101BaldAPI.AssetTools;
using MTM101BaldAPI.ObjectCreation;
using MTM101BaldAPI.Registers;
using System.Collections;
using UnityEngine;

namespace TotalSplaatMadness
{
    [BepInPlugin("sticky.bbplus.splaatvariants", "Total Splaat Madness", "0.0.1")]

    [BepInDependency("mtm101.rulerp.bbplus.baldidevapi")]

    public class BasePlugin : BaseUnityPlugin
    {
        public AssetManager assetMan = new AssetManager();
        private static string npcSubDirectory = "Textures/NPCs";
        private static string npcAudioSubDirectory = "Audio/NPCs";

        private IEnumerator RegisterAssets()
        {
            yield return 2;

            yield return "Building variants...";

            Splaat NormalSplaat = new NPCBuilder<Splaat>(Info)
              .SetName("Splaat")
              .SetEnum("NormalSplaat")
              .SetMinMaxAudioDistance(1, 300)
              .IgnorePlayerOnSpawn()
              .AddSpawnableRoomCategories(new RoomCategory[] { RoomCategory.Hall, RoomCategory.Class, RoomCategory.Office, RoomCategory.Faculty })
              .SetPoster(assetMan.Get<Texture2D>("Normal Splaat Poster"), "Splaat", "An ink splat that wanders around the school, while singing the Klasky Csupo 1998 Splaat logo. No clue why he\'s here.")
              .Build();

            GMajorSplaat RealGMajorSplaat = new NPCBuilder<GMajorSplaat>(Info)
  .SetName("G-Major Splaat")
  .SetEnum("RealGMajorSplaat")
  .SetMinMaxAudioDistance(1, 300)
  .IgnorePlayerOnSpawn()
  .AddSpawnableRoomCategories(new RoomCategory[] { RoomCategory.Hall, RoomCategory.Class, RoomCategory.Office, RoomCategory.Faculty })
  .SetPoster(assetMan.Get<Texture2D>("G Major Splaat Poster"), "G-Major Splaat", "A demonic version of Splaat, that somehow got popularized by the logo editing community...")
  .Build();

            yield return "Doing some miscellaneous stuff...";

            NormalSplaat.normalSplaatSprite = assetMan.Get<Sprite>("Normal Splaat Sprite");
            NormalSplaat.normalKlaskyCsupo = assetMan.Get<SoundObject>("Normal Splaat Music");
            RealGMajorSplaat.gmajorSplaatSprite = assetMan.Get<Sprite>("G Major Splaat Sprite");
            RealGMajorSplaat.gmajorKlaskyCsupo = assetMan.Get<SoundObject>("G Major Splaat Music");

            assetMan.Add<NPC>("Splaat", NormalSplaat);
            assetMan.Add<NPC>("G-Major Splaat", RealGMajorSplaat);

            yield break;
        }

        private void GetAssets() // this is gonna be thousands of lines of code for the rest of the splaat variants
        {
            assetMan.Add<Texture2D>("Normal Splaat Texture", AssetLoader.TextureFromMod(this, npcSubDirectory, "NormalSplaat.png"));
            assetMan.Add<Texture2D>("Normal Splaat Poster", AssetLoader.TextureFromMod(this, npcSubDirectory, "NormalSplaatPoster.png"));
            assetMan.Add<Sprite>("Normal Splaat Sprite", AssetLoader.SpriteFromTexture2D(assetMan.Get<Texture2D>("Normal Splaat Texture"), 100));
            Color normalSplaatColor = new Color32(36, 75, 145, 255);
            assetMan.Add<SoundObject>("Normal Splaat Music", ObjectCreators.CreateSoundObject(AssetLoader.AudioClipFromMod(this, npcAudioSubDirectory, "NormalSplaatFixed.WAV"), "*Music*", SoundType.Music, normalSplaatColor));
            assetMan.Add<Texture2D>("G Major Splaat Texture", AssetLoader.TextureFromMod(this, npcSubDirectory, "GMajorSplaat.png"));
            assetMan.Add<Texture2D>("G Major Splaat Poster", AssetLoader.TextureFromMod(this, npcSubDirectory, "GMajorSplaatPoster.png"));
            assetMan.Add<Sprite>("G Major Splaat Sprite", AssetLoader.SpriteFromTexture2D(assetMan.Get<Texture2D>("G Major Splaat Texture"), 100));
            assetMan.Add<SoundObject>("G Major Splaat Music", ObjectCreators.CreateSoundObject(AssetLoader.AudioClipFromMod(this, npcAudioSubDirectory, "GMajorSplaat.mp3"), "*Music*", SoundType.Music, Color.white));
        }

        public void Awake()
        {
            Harmony harmony = new Harmony("sticky.bbplus.splaatvariants");

            harmony.PatchAll();

            GetAssets();

            LoadingEvents.RegisterOnAssetsLoaded(Info, RegisterAssets(), LoadingEventOrder.Pre);
            GeneratorManagement.Register(this, GenerationModType.Addend, AddObjects);
        }

        private void AddObjects(string floor, int floorNumber, SceneObject floorObject)
        {
            if (floor.StartsWith("F"))
            {
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Splaat"),
                    weight = floorNumber < 2 ? 350 * floorNumber : 600
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("G-Major Splaat"),
                    weight = floorNumber < 2 ? 165 * floorNumber : 300
                }
                );
            }
            else if (floor == "END")
            {
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Splaat"),
                    weight = 600
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("G-Major Splaat"),
                    weight = 300
                }
                );
            }

            floorObject.MarkAsNeverUnload();
        }
    }
}