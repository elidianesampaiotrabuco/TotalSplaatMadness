using MTM101BaldAPI.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TotalSplaatMadness
{
    public class HighSplaat : NPC
    {
        public Sprite highSplaatSprite;
        public SoundObject highKlaskyCsupo;

        public override void Initialize()
        {
            base.Initialize();

            spriteRenderer[0].sprite = highSplaatSprite;

            AudioManager audioManager = GetComponent<AudioManager>();
            PropagatedAudioManager highKlaskyCsupoPlayer = base.gameObject.AddComponent<PropagatedAudioManager>();
            highKlaskyCsupoPlayer.audioDevice = base.gameObject.AddComponent<AudioSource>();
            highKlaskyCsupoPlayer.ReflectionSetVariable("soundOnStart", new SoundObject[] { highKlaskyCsupo });
            highKlaskyCsupoPlayer.ReflectionSetVariable("loopOnStart", true);

            behaviorStateMachine.ChangeState(new HighSplaat_Wander(this));
        }
    }

    public class HighSplaat_StateBase : NpcState
    {
        protected HighSplaat highSplaat;

        public HighSplaat_StateBase(HighSplaat high) : base(high)
        {
            highSplaat = high;
        }
    }

    public class HighSplaat_Wander : HighSplaat_StateBase
    {
        public HighSplaat_Wander(HighSplaat high) : base(high)
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
