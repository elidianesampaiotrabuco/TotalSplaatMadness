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
    [BepInPlugin("sticky.bbplus.splaatvariants", "Total Splaat Madness", "0.2.0")]

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

            ReversedSplaat RealReversedSplaat = new NPCBuilder<ReversedSplaat>(Info)
.SetName("Reversed Splaat")
.SetEnum("RealReversedSplaat")
.SetMinMaxAudioDistance(1, 300)
.IgnorePlayerOnSpawn()
.AddSpawnableRoomCategories(new RoomCategory[] { RoomCategory.Hall, RoomCategory.Class, RoomCategory.Office, RoomCategory.Faculty })
.SetPoster(assetMan.Get<Texture2D>("Reversed Splaat Poster"), "taalpS", ".ereh s\'eh yhw eulc oN .ogol taalpS 8991 opusC yksalK eht gnignis elihw ,loohcs eht dnuora srednaw taht talps kni nA")
.Build();

            WeirdCodeSplaat RealWeirdCodeSplaat = new NPCBuilder<WeirdCodeSplaat>(Info)
.SetName("Weird Code Splaat")
.SetEnum("RealWeirdCodeSplaat")
.SetMinMaxAudioDistance(1, 300)
.IgnorePlayerOnSpawn()
.AddSpawnableRoomCategories(new RoomCategory[] { RoomCategory.Hall, RoomCategory.Class, RoomCategory.Office, RoomCategory.Faculty })
.SetPoster(assetMan.Get<Texture2D>("Weird Code Splaat Poster"), "Weird Code Splaat", "-.- .-.. .- ... -.- -.-- / -.-. ... ..- .--. ---")
.Build();

            NotScarySplaat RealNotScarySplaat = new NPCBuilder<NotScarySplaat>(Info)
.SetName("Not Scary Splaat")
.SetEnum("RealNotScarySplaat")
.SetMinMaxAudioDistance(1, 300)
.IgnorePlayerOnSpawn()
.AddSpawnableRoomCategories(new RoomCategory[] { RoomCategory.Hall, RoomCategory.Class, RoomCategory.Office, RoomCategory.Faculty })
.SetPoster(assetMan.Get<Texture2D>("Not Scary Splaat Poster"), "Not Scary Splaat", "Totally not scary!")
.Build();

            DUHSplaat RealDUHSplaat = new NPCBuilder<DUHSplaat>(Info)
.SetName("DUH Splaat")
.SetEnum("RealDUHSplaat")
.SetMinMaxAudioDistance(1, 300)
.IgnorePlayerOnSpawn()
.AddSpawnableRoomCategories(new RoomCategory[] { RoomCategory.Hall, RoomCategory.Class, RoomCategory.Office, RoomCategory.Faculty })
.SetPoster(assetMan.Get<Texture2D>("DUH Splaat Poster"), "DUH Splaat", "The Splaat that most YTP tennisers love, as an effect! Although some aren\'t in the logo editing community...")
.Build();

            LowVoiceSplaat RealLowVoiceSplaat = new NPCBuilder<LowVoiceSplaat>(Info)
.SetName("Low Voice Splaat")
.SetEnum("RealLowVoiceSplaat")
.SetMinMaxAudioDistance(1, 300)
.IgnorePlayerOnSpawn()
.AddSpawnableRoomCategories(new RoomCategory[] { RoomCategory.Hall, RoomCategory.Class, RoomCategory.Office, RoomCategory.Faculty })
.SetPoster(assetMan.Get<Texture2D>("Low Voice Splaat Poster"), "Low Voice Splaat", "A color inverted and mirrored Splaat that wanders around the school, singing slowly.")
.Build();

            FormulatorV975Splaat Real4ormulatorV975Splaat = new NPCBuilder<FormulatorV975Splaat>(Info)
.SetName("4ormulator V975 Splaat")
.SetEnum("Real4ormulatorV975Splaat")
.SetMinMaxAudioDistance(1, 300)
.IgnorePlayerOnSpawn()
.AddSpawnableRoomCategories(new RoomCategory[] { RoomCategory.Hall, RoomCategory.Class, RoomCategory.Office, RoomCategory.Faculty })
.SetPoster(assetMan.Get<Texture2D>("4ormulator V975 Splaat Poster"), "4ormulator V975 Splaat", "4ormulator effect that simply wanders around the map. 4ormulator effects have come into town...")
.Build();

            KormulatorV458Splaat RealKormulatorV458Splaat = new NPCBuilder<KormulatorV458Splaat>(Info)
.SetName("Kormulator V458 Splaat")
.SetEnum("RealKormulatorV458Splaat")
.SetMinMaxAudioDistance(1, 300)
.IgnorePlayerOnSpawn()
.AddSpawnableRoomCategories(new RoomCategory[] { RoomCategory.Hall, RoomCategory.Class, RoomCategory.Office, RoomCategory.Faculty })
.SetPoster(assetMan.Get<Texture2D>("Kormulator V458 Splaat Poster"), "Kormulator V458 Splaat", "This Splaat can bleed your ears...")
.Build();

            KormulatorV474Splaat RealKormulatorV474Splaat = new NPCBuilder<KormulatorV474Splaat>(Info)
.SetName("Kormulator V474 Splaat")
.SetEnum("RealKormulatorV474Splaat")
.SetMinMaxAudioDistance(1, 300)
.IgnorePlayerOnSpawn()
.AddSpawnableRoomCategories(new RoomCategory[] { RoomCategory.Hall, RoomCategory.Class, RoomCategory.Office, RoomCategory.Faculty })
.SetPoster(assetMan.Get<Texture2D>("Kormulator V474 Splaat Poster"), "Kormulator V474 Splaat", "A strange looking Splaat, that looks like an insect. Still kinda ear bleedy, tho.")
.Build();

            OofedSplaat RealOofedSplaat = new NPCBuilder<OofedSplaat>(Info)
.SetName("Oofed Splaat")
.SetEnum("RealOofedSplaat")
.SetMinMaxAudioDistance(1, 300)
.IgnorePlayerOnSpawn()
.AddSpawnableRoomCategories(new RoomCategory[] { RoomCategory.Hall, RoomCategory.Class, RoomCategory.Office, RoomCategory.Faculty })
.SetPoster(assetMan.Get<Texture2D>("Oofed Splaat Poster"), "Oofed Splaat", "OUCH!")
.Build();

            HighSplaat RealHighSplaat = new NPCBuilder<HighSplaat>(Info)
.SetName("High Splaat")
.SetEnum("RealHighSplaat")
.SetMinMaxAudioDistance(1, 300)
.IgnorePlayerOnSpawn()
.AddSpawnableRoomCategories(new RoomCategory[] { RoomCategory.Hall, RoomCategory.Class, RoomCategory.Office, RoomCategory.Faculty })
.SetPoster(assetMan.Get<Texture2D>("High Splaat Poster"), "High Splaat", "A Splaat that wanders around the map. He has a relationship with Spoiled Splaat.")
.Build();

            SpoiledSplaat RealSpoiledSplaat = new NPCBuilder<SpoiledSplaat>(Info)
.SetName("Spoiled Splaat")
.SetEnum("RealSpoiledSplaat")
.SetMinMaxAudioDistance(1, 300)
.IgnorePlayerOnSpawn()
.AddSpawnableRoomCategories(new RoomCategory[] { RoomCategory.Hall, RoomCategory.Class, RoomCategory.Office, RoomCategory.Faculty })
.SetPoster(assetMan.Get<Texture2D>("Spoiled Splaat Poster"), "Spoiled Splaat", "Ripply Splaat that wanders around the map. Has relationship with High Splaat.")
.Build();

            yield return "Doing some miscellaneous stuff...";

            NormalSplaat.normalSplaatSprite = assetMan.Get<Sprite>("Normal Splaat Sprite");
            NormalSplaat.normalKlaskyCsupo = assetMan.Get<SoundObject>("Normal Splaat Music");
            RealGMajorSplaat.gmajorSplaatSprite = assetMan.Get<Sprite>("G Major Splaat Sprite");
            RealGMajorSplaat.gmajorKlaskyCsupo = assetMan.Get<SoundObject>("G Major Splaat Music");
            RealReversedSplaat.reversedSplaatSprite = assetMan.Get<Sprite>("Reversed Splaat Sprite");
            RealReversedSplaat.reversedKlaskyCsupo = assetMan.Get<SoundObject>("Reversed Splaat Music");
            RealWeirdCodeSplaat.weirdCodeSplaatSprite = assetMan.Get<Sprite>("Weird Code Splaat Sprite");
            RealWeirdCodeSplaat.weirdCodeKlaskyCsupo = assetMan.Get<SoundObject>("Weird Code Splaat Music");
            RealNotScarySplaat.notScarySplaatSprite = assetMan.Get<Sprite>("Not Scary Splaat Sprite");
            RealNotScarySplaat.notScaryKlaskyCsupo = assetMan.Get<SoundObject>("Not Scary Splaat Music");
            RealDUHSplaat.duhSplaatSprite = assetMan.Get<Sprite>("DUH Splaat Sprite");
            RealDUHSplaat.duhKlaskyCsupo = assetMan.Get<SoundObject>("DUH Splaat Music");
            RealLowVoiceSplaat.lowVoiceSplaatSprite = assetMan.Get<Sprite>("Low Voice Splaat Sprite");
            RealLowVoiceSplaat.lowVoiceKlaskyCsupo = assetMan.Get<SoundObject>("Low Voice Splaat Music");
            Real4ormulatorV975Splaat.formulator975SplaatSprite = assetMan.Get<Sprite>("4ormulator V975 Splaat Sprite");
            Real4ormulatorV975Splaat.formulator975KlaskyCsupo = assetMan.Get<SoundObject>("4ormulator V975 Splaat Music");
            RealKormulatorV458Splaat.kormulator458SplaatSprite = assetMan.Get<Sprite>("Kormulator V458 Splaat Sprite");
            RealKormulatorV458Splaat.kormulator458KlaskyCsupo = assetMan.Get<SoundObject>("Kormulator V458 Splaat Music");
            RealKormulatorV474Splaat.kormulator474SplaatSprite = assetMan.Get<Sprite>("Kormulator V474 Splaat Sprite");
            RealKormulatorV474Splaat.kormulator474KlaskyCsupo = assetMan.Get<SoundObject>("Kormulator V474 Splaat Music");
            RealOofedSplaat.oofedSplaatSprite = assetMan.Get<Sprite>("Oofed Splaat Sprite");
            RealOofedSplaat.oofedKlaskyCsupo = assetMan.Get<SoundObject>("Oofed Splaat Music");
            RealHighSplaat.highSplaatSprite = assetMan.Get<Sprite>("High Splaat Sprite");
            RealHighSplaat.highKlaskyCsupo = assetMan.Get<SoundObject>("High Splaat Music");
            RealSpoiledSplaat.spoiledSplaatSprite = assetMan.Get<Sprite>("Spoiled Splaat Sprite");
            RealSpoiledSplaat.spoiledKlaskyCsupo = assetMan.Get<SoundObject>("Spoiled Splaat Music");

            assetMan.Add<NPC>("Splaat", NormalSplaat);
            assetMan.Add<NPC>("G-Major Splaat", RealGMajorSplaat);
            assetMan.Add<NPC>("Reversed Splaat", RealReversedSplaat);
            assetMan.Add<NPC>("Weird Code Splaat", RealWeirdCodeSplaat);
            assetMan.Add<NPC>("Not Scary Splaat", RealNotScarySplaat);
            assetMan.Add<NPC>("DUH Splaat", RealDUHSplaat);
            assetMan.Add<NPC>("Low Voice Splaat", RealLowVoiceSplaat);
            assetMan.Add<NPC>("4ormulator V975 Splaat", Real4ormulatorV975Splaat);
            assetMan.Add<NPC>("Kormulator V458 Splaat", RealKormulatorV458Splaat);
            assetMan.Add<NPC>("Kormulator V474 Splaat", RealKormulatorV474Splaat);
            assetMan.Add<NPC>("Oofed Splaat", RealOofedSplaat);
            assetMan.Add<NPC>("High Splaat", RealHighSplaat);
            assetMan.Add<NPC>("Spoiled Splaat", RealSpoiledSplaat);

            yield break;
        }

        private void GetAssets() // this is gonna be thousands of lines of code for the rest of the splaat variants
        {
            // Splaat
            assetMan.Add<Texture2D>("Normal Splaat Texture", AssetLoader.TextureFromMod(this, npcSubDirectory, "NormalSplaat.png"));
            assetMan.Add<Texture2D>("Normal Splaat Poster", AssetLoader.TextureFromMod(this, npcSubDirectory, "NormalSplaatPoster.png"));
            assetMan.Add<Sprite>("Normal Splaat Sprite", AssetLoader.SpriteFromTexture2D(assetMan.Get<Texture2D>("Normal Splaat Texture"), 100));
            Color normalSplaatColor = new Color32(36, 75, 145, 255);
            assetMan.Add<SoundObject>("Normal Splaat Music", ObjectCreators.CreateSoundObject(AssetLoader.AudioClipFromMod(this, npcAudioSubDirectory, "NormalSplaatFixed.WAV"), "*Music*", SoundType.Music, normalSplaatColor));
            // G-Major Splaat
            assetMan.Add<Texture2D>("G Major Splaat Texture", AssetLoader.TextureFromMod(this, npcSubDirectory, "GMajorSplaat.png"));
            assetMan.Add<Texture2D>("G Major Splaat Poster", AssetLoader.TextureFromMod(this, npcSubDirectory, "GMajorSplaatPoster.png"));
            assetMan.Add<Sprite>("G Major Splaat Sprite", AssetLoader.SpriteFromTexture2D(assetMan.Get<Texture2D>("G Major Splaat Texture"), 100));
            assetMan.Add<SoundObject>("G Major Splaat Music", ObjectCreators.CreateSoundObject(AssetLoader.AudioClipFromMod(this, npcAudioSubDirectory, "GMajorSplaat.mp3"), "*Music*", SoundType.Music, Color.white));
            // Reversed Splaat
            assetMan.Add<Texture2D>("Reversed Splaat Texture", AssetLoader.TextureFromMod(this, npcSubDirectory, "ReversedSplaat.png"));
            assetMan.Add<Texture2D>("Reversed Splaat Poster", AssetLoader.TextureFromMod(this, npcSubDirectory, "ReversedSplaatPoster.png"));
            assetMan.Add<Sprite>("Reversed Splaat Sprite", AssetLoader.SpriteFromTexture2D(assetMan.Get<Texture2D>("Reversed Splaat Texture"), 100));
            assetMan.Add<SoundObject>("Reversed Splaat Music", ObjectCreators.CreateSoundObject(AssetLoader.AudioClipFromMod(this, npcAudioSubDirectory, "ReversedSplaat.mp3"), "*cisuM*", SoundType.Music, normalSplaatColor));
            // Weird Code Splaat
            assetMan.Add<Texture2D>("Weird Code Splaat Texture", AssetLoader.TextureFromMod(this, npcSubDirectory, "WeirdCodeSplaat.png"));
            assetMan.Add<Texture2D>("Weird Code Splaat Poster", AssetLoader.TextureFromMod(this, npcSubDirectory, "WeirdCodeSplaatPoster.png"));
            assetMan.Add<Sprite>("Weird Code Splaat Sprite", AssetLoader.SpriteFromTexture2D(assetMan.Get<Texture2D>("Weird Code Splaat Texture"), 100));
            assetMan.Add<SoundObject>("Weird Code Splaat Music", ObjectCreators.CreateSoundObject(AssetLoader.AudioClipFromMod(this, npcAudioSubDirectory, "WeirdCodeSplaat.mp3"), "*Weird music*", SoundType.Music, Color.blue));
            // Not Scary Splaat
            assetMan.Add<Texture2D>("Not Scary Splaat Texture", AssetLoader.TextureFromMod(this, npcSubDirectory, "NotScarySplaat.png"));
            assetMan.Add<Texture2D>("Not Scary Splaat Poster", AssetLoader.TextureFromMod(this, npcSubDirectory, "NotScarySplaatPoster.png"));
            assetMan.Add<Sprite>("Not Scary Splaat Sprite", AssetLoader.SpriteFromTexture2D(assetMan.Get<Texture2D>("Not Scary Splaat Texture"), 100));
            assetMan.Add<SoundObject>("Not Scary Splaat Music", ObjectCreators.CreateSoundObject(AssetLoader.AudioClipFromMod(this, npcAudioSubDirectory, "NotScarySplaat.mp3"), "*Music*", SoundType.Music, Color.blue));
            // DUH Splaat
            assetMan.Add<Texture2D>("DUH Splaat Texture", AssetLoader.TextureFromMod(this, npcSubDirectory, "DUHSplaat.png"));
            assetMan.Add<Texture2D>("DUH Splaat Poster", AssetLoader.TextureFromMod(this, npcSubDirectory, "DUHSplaatPoster.png"));
            assetMan.Add<Sprite>("DUH Splaat Sprite", AssetLoader.SpriteFromTexture2D(assetMan.Get<Texture2D>("DUH Splaat Texture"), 100));
            assetMan.Add<SoundObject>("DUH Splaat Music", ObjectCreators.CreateSoundObject(AssetLoader.AudioClipFromMod(this, npcAudioSubDirectory, "DUHSplaat.mp3"), "*Loud chorus music*", SoundType.Music, Color.white));
            // Low Voice Splaat
            assetMan.Add<Texture2D>("Low Voice Splaat Texture", AssetLoader.TextureFromMod(this, npcSubDirectory, "LowVoiceSplaat.png"));
            assetMan.Add<Texture2D>("Low Voice Splaat Poster", AssetLoader.TextureFromMod(this, npcSubDirectory, "LowVoiceSplaatPoster.png"));
            assetMan.Add<Sprite>("Low Voice Splaat Sprite", AssetLoader.SpriteFromTexture2D(assetMan.Get<Texture2D>("Low Voice Splaat Texture"), 100));
            Color lowVoiceSplaatColor = new Color32(158, 182, 212, 255);
            assetMan.Add<SoundObject>("Low Voice Splaat Music", ObjectCreators.CreateSoundObject(AssetLoader.AudioClipFromMod(this, npcAudioSubDirectory, "LowVoiceSplaat.mp3"), "*Music*", SoundType.Music, lowVoiceSplaatColor));
            // 4ormulator V975 Splaat (Formulator V975 Splaat in code due to C# limitations)
            assetMan.Add<Texture2D>("4ormulator V975 Splaat Texture", AssetLoader.TextureFromMod(this, npcSubDirectory, "4ormulatorV975Splaat.png"));
            assetMan.Add<Texture2D>("4ormulator V975 Splaat Poster", AssetLoader.TextureFromMod(this, npcSubDirectory, "4ormulatorV975SplaatPoster.png"));
            assetMan.Add<Sprite>("4ormulator V975 Splaat Sprite", AssetLoader.SpriteFromTexture2D(assetMan.Get<Texture2D>("4ormulator V975 Splaat Texture"), 100));
            assetMan.Add<SoundObject>("4ormulator V975 Splaat Music", ObjectCreators.CreateSoundObject(AssetLoader.AudioClipFromMod(this, npcAudioSubDirectory, "4ormulatorV975Splaat.mp3"), "*Music*", SoundType.Music, Color.white));
            // Kormulator V458 Splaat
            assetMan.Add<Texture2D>("Kormulator V458 Splaat Texture", AssetLoader.TextureFromMod(this, npcSubDirectory, "KormulatorV458Splaat.png"));
            assetMan.Add<Texture2D>("Kormulator V458 Splaat Poster", AssetLoader.TextureFromMod(this, npcSubDirectory, "KormulatorV458SplaatPoster.png"));
            assetMan.Add<Sprite>("Kormulator V458 Splaat Sprite", AssetLoader.SpriteFromTexture2D(assetMan.Get<Texture2D>("Kormulator V458 Splaat Texture"), 100));
            assetMan.Add<SoundObject>("Kormulator V458 Splaat Music", ObjectCreators.CreateSoundObject(AssetLoader.AudioClipFromMod(this, npcAudioSubDirectory, "KormulatorV458Splaat.mp3"), "*Loud noises*", SoundType.Music, normalSplaatColor));
            // Kormulator V474 Splaat
            assetMan.Add<Texture2D>("Kormulator V474 Splaat Texture", AssetLoader.TextureFromMod(this, npcSubDirectory, "KormulatorV474Splaat.png"));
            assetMan.Add<Texture2D>("Kormulator V474 Splaat Poster", AssetLoader.TextureFromMod(this, npcSubDirectory, "KormulatorV474SplaatPoster.png"));
            assetMan.Add<Sprite>("Kormulator V474 Splaat Sprite", AssetLoader.SpriteFromTexture2D(assetMan.Get<Texture2D>("Kormulator V474 Splaat Texture"), 100));
            assetMan.Add<SoundObject>("Kormulator V474 Splaat Music", ObjectCreators.CreateSoundObject(AssetLoader.AudioClipFromMod(this, npcAudioSubDirectory, "KormulatorV474Splaat.mp3"), "*Muffled music*", SoundType.Music, Color.green));
            // Oofed Splaat
            assetMan.Add<Texture2D>("Oofed Splaat Texture", AssetLoader.TextureFromMod(this, npcSubDirectory, "OofedSplaat.png"));
            assetMan.Add<Texture2D>("Oofed Splaat Poster", AssetLoader.TextureFromMod(this, npcSubDirectory, "OofedSplaatPoster.png"));
            assetMan.Add<Sprite>("Oofed Splaat Sprite", AssetLoader.SpriteFromTexture2D(assetMan.Get<Texture2D>("Oofed Splaat Texture"), 100));
            Color purpleColor = new Color32(93, 63, 211, 255);
            assetMan.Add<SoundObject>("Oofed Splaat Music", ObjectCreators.CreateSoundObject(AssetLoader.AudioClipFromMod(this, npcAudioSubDirectory, "OofedSplaat.mp3"), "*Music*", SoundType.Music, purpleColor));
            // High Splaat
            assetMan.Add<Texture2D>("High Splaat Texture", AssetLoader.TextureFromMod(this, npcSubDirectory, "HighSplaat.png"));
            assetMan.Add<Texture2D>("High Splaat Poster", AssetLoader.TextureFromMod(this, npcSubDirectory, "HighSplaatPoster.png"));
            assetMan.Add<Sprite>("High Splaat Sprite", AssetLoader.SpriteFromTexture2D(assetMan.Get<Texture2D>("High Splaat Texture"), 100));
            assetMan.Add<SoundObject>("High Splaat Music", ObjectCreators.CreateSoundObject(AssetLoader.AudioClipFromMod(this, npcAudioSubDirectory, "HighSplaat.mp3"), "*musIC*", SoundType.Music, normalSplaatColor));
            // Spoiled Splaat
            assetMan.Add<Texture2D>("Spoiled Splaat Texture", AssetLoader.TextureFromMod(this, npcSubDirectory, "SpoiledSplaat.png"));
            assetMan.Add<Texture2D>("Spoiled Splaat Poster", AssetLoader.TextureFromMod(this, npcSubDirectory, "SpoiledSplaatPoster.png"));
            assetMan.Add<Sprite>("Spoiled Splaat Sprite", AssetLoader.SpriteFromTexture2D(assetMan.Get<Texture2D>("Spoiled Splaat Texture"), 100));
            assetMan.Add<SoundObject>("Spoiled Splaat Music", ObjectCreators.CreateSoundObject(AssetLoader.AudioClipFromMod(this, npcAudioSubDirectory, "SpoiledSplaat.mp3"), "*MUsic*", SoundType.Music, normalSplaatColor));
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
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Reversed Splaat"),
                    weight = floorNumber < 2 ? 65 * floorNumber : 200
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Weird Code Splaat"),
                    weight = floorNumber < 2 ? 50 * floorNumber : 275
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Not Scary Splaat"),
                    weight = floorNumber < 2 ? 500 * floorNumber : 765
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("DUH Splaat"),
                    weight = floorNumber < 2 ? 800 * floorNumber : 1015
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Low Voice Splaat"),
                    weight = floorNumber < 2 ? 20 * floorNumber : 100
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("4ormulator V975 Splaat"),
                    weight = floorNumber < 2 ? 1010 * floorNumber : 1100
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Kormulator V458 Splaat"),
                    weight = floorNumber < 2 ? 1145 * floorNumber : 1200
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Kormulator V474 Splaat"),
                    weight = floorNumber < 2 ? 1145 * floorNumber : 1200
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Oofed Splaat"),
                    weight = floorNumber < 2 ? 10 * floorNumber : 50
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("High Splaat"),
                    weight = floorNumber < 2 ? 950 * floorNumber : 1000
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Spoiled Splaat"),
                    weight = floorNumber < 2 ? 875 * floorNumber : 950
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
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Reversed Splaat"),
                    weight = 200
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Weird Code Splaat"),
                    weight = 275
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Not Scary Splaat"),
                    weight = 765
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("DUH Splaat"),
                    weight = 1015
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Low Voice Splaat"),
                    weight = 100
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("4ormulator V975 Splaat"),
                    weight = 1100
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Kormulator V458 Splaat"),
                    weight = 1200
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Kormulator V474 Splaat"),
                    weight = 1200
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Oofed Splaat"),
                    weight = 50
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("High Splaat"),
                    weight = 1000
                }
                );
                floorObject.potentialNPCs.Add(new WeightedNPC()
                {
                    selection = assetMan.Get<NPC>("Spoiled Splaat"),
                    weight = 1000
                }
                );
            }

            floorObject.MarkAsNeverUnload();
        }
    }
}