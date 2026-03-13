using MTM101BaldAPI.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TotalSplaatMadness
{
    public class SpoiledSplaat : NPC
    {
        public Sprite spoiledSplaatSprite;
        public SoundObject spoiledKlaskyCsupo;

        public override void Initialize()
        {
            base.Initialize();

            spriteRenderer[0].sprite = spoiledSplaatSprite;

            AudioManager audioManager = GetComponent<AudioManager>();
            PropagatedAudioManager spoiledKlaskyCsupoPlayer = base.gameObject.AddComponent<PropagatedAudioManager>();
            spoiledKlaskyCsupoPlayer.audioDevice = base.gameObject.AddComponent<AudioSource>();
            spoiledKlaskyCsupoPlayer.ReflectionSetVariable("soundOnStart", new SoundObject[] { spoiledKlaskyCsupo });
            spoiledKlaskyCsupoPlayer.ReflectionSetVariable("loopOnStart", true);

            behaviorStateMachine.ChangeState(new SpoiledSplaat_Wander(this));
        }
    }

    public class SpoiledSplaat_StateBase : NpcState
    {
        protected SpoiledSplaat spoiledSplaat;

        public SpoiledSplaat_StateBase(SpoiledSplaat spoil) : base(spoil)
        {
            spoiledSplaat = spoil;
        }
    }

    public class SpoiledSplaat_Wander : SpoiledSplaat_StateBase
    {
        public SpoiledSplaat_Wander(SpoiledSplaat spoil) : base(spoil)
        {

        }

        public override void Enter()
        {
            base.Enter();
            if (!npc.Navigator.HasDestination)
            {
                ChangeNavigationState(new NavigationState_WanderRandom(npc, 0));
            }
        }

        public override void DestinationEmpty()
        {
            base.DestinationEmpty();
            ChangeNavigationState(new NavigationState_WanderRandom(npc, 0));
        }
    }
}
