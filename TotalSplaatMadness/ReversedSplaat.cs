using MTM101BaldAPI.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TotalSplaatMadness
{
    public class ReversedSplaat : NPC
    {
        public Sprite reversedSplaatSprite;
        public SoundObject reversedKlaskyCsupo;

        public override void Initialize()
        {
            base.Initialize();

            spriteRenderer[0].sprite = reversedSplaatSprite;

            AudioManager audioManager = GetComponent<AudioManager>();
            PropagatedAudioManager reversedKlaskyCsupoPlayer = base.gameObject.AddComponent<PropagatedAudioManager>();
            reversedKlaskyCsupoPlayer.audioDevice = base.gameObject.AddComponent<AudioSource>();
            reversedKlaskyCsupoPlayer.ReflectionSetVariable("soundOnStart", new SoundObject[] { reversedKlaskyCsupo });
            reversedKlaskyCsupoPlayer.ReflectionSetVariable("loopOnStart", true);

            behaviorStateMachine.ChangeState(new ReversedSplaat_Wander(this));
        }
    }

    public class ReversedSplaat_StateBase : NpcState
    {
        protected ReversedSplaat reversedSplaat;

        public ReversedSplaat_StateBase(ReversedSplaat reverse) : base(reverse)
        {
            reversedSplaat = reverse;
        }
    }

    public class ReversedSplaat_Wander : ReversedSplaat_StateBase
    {
        public ReversedSplaat_Wander(ReversedSplaat reverse) : base(reverse)
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
