using MTM101BaldAPI.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TotalSplaatMadness
{
    public class GMajorSplaat : NPC
    {
        public Sprite gmajorSplaatSprite;
        public SoundObject gmajorKlaskyCsupo;

        public override void Initialize()
        {
            base.Initialize();

            spriteRenderer[0].sprite = gmajorSplaatSprite;

            AudioManager audioManager = GetComponent<AudioManager>();
            PropagatedAudioManager gmajorKlaskyCsupoPlayer = base.gameObject.AddComponent<PropagatedAudioManager>();
            gmajorKlaskyCsupoPlayer.audioDevice = base.gameObject.AddComponent<AudioSource>();
            gmajorKlaskyCsupoPlayer.ReflectionSetVariable("soundOnStart", new SoundObject[] { gmajorKlaskyCsupo });
            gmajorKlaskyCsupoPlayer.ReflectionSetVariable("loopOnStart", true);

            behaviorStateMachine.ChangeState(new GMajorSplaat_Wander(this));
        }
    }

    public class GMajorSplaat_StateBase : NpcState
    {
        protected GMajorSplaat gmajorSplaat;

        public GMajorSplaat_StateBase(GMajorSplaat gmajor) : base(gmajor)
        {
            gmajorSplaat = gmajor;
        }
    }

    public class GMajorSplaat_Wander : GMajorSplaat_StateBase
    {
        public GMajorSplaat_Wander(GMajorSplaat gmajor) : base(gmajor)
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
