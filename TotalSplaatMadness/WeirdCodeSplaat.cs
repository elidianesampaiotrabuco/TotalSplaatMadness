using MTM101BaldAPI.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TotalSplaatMadness
{
    public class WeirdCodeSplaat : NPC
    {
        public Sprite weirdCodeSplaatSprite;
        public SoundObject weirdCodeKlaskyCsupo;

        public override void Initialize()
        {
            base.Initialize();

            spriteRenderer[0].sprite = weirdCodeSplaatSprite;

            AudioManager audioManager = GetComponent<AudioManager>();
            PropagatedAudioManager weirdCodeKlaskyCsupoPlayer = base.gameObject.AddComponent<PropagatedAudioManager>();
            weirdCodeKlaskyCsupoPlayer.audioDevice = base.gameObject.AddComponent<AudioSource>();
            weirdCodeKlaskyCsupoPlayer.ReflectionSetVariable("soundOnStart", new SoundObject[] { weirdCodeKlaskyCsupo });
            weirdCodeKlaskyCsupoPlayer.ReflectionSetVariable("loopOnStart", true);

            behaviorStateMachine.ChangeState(new WeirdCodeSplaat_Wander(this));
        }
    }

    public class WeirdCodeSplaat_StateBase : NpcState
    {
        protected WeirdCodeSplaat weirdCodeSplaat;

        public WeirdCodeSplaat_StateBase(WeirdCodeSplaat weirdcode) : base(weirdcode)
        {
            weirdCodeSplaat = weirdcode;
        }
    }

    public class WeirdCodeSplaat_Wander : WeirdCodeSplaat_StateBase
    {
        public WeirdCodeSplaat_Wander(WeirdCodeSplaat weirdcode) : base(weirdcode)
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
