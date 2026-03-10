using MTM101BaldAPI.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TotalSplaatMadness
{
    public class LowVoiceSplaat : NPC
    {
        public Sprite lowVoiceSplaatSprite;
        public SoundObject lowVoiceKlaskyCsupo;

        public override void Initialize()
        {
            base.Initialize();

            spriteRenderer[0].sprite = lowVoiceSplaatSprite;

            AudioManager audioManager = GetComponent<AudioManager>();
            PropagatedAudioManager lowVoiceKlaskyCsupoPlayer = base.gameObject.AddComponent<PropagatedAudioManager>();
            lowVoiceKlaskyCsupoPlayer.audioDevice = base.gameObject.AddComponent<AudioSource>();
            lowVoiceKlaskyCsupoPlayer.ReflectionSetVariable("soundOnStart", new SoundObject[] { lowVoiceKlaskyCsupo });
            lowVoiceKlaskyCsupoPlayer.ReflectionSetVariable("loopOnStart", true);

            behaviorStateMachine.ChangeState(new LowVoiceSplaat_Wander(this));
        }
    }

    public class LowVoiceSplaat_StateBase : NpcState
    {
        protected LowVoiceSplaat lowVoiceSplaat;

        public LowVoiceSplaat_StateBase(LowVoiceSplaat lowvoice) : base(lowvoice)
        {
            lowVoiceSplaat = lowvoice;
        }
    }

    public class LowVoiceSplaat_Wander : LowVoiceSplaat_StateBase
    {
        public LowVoiceSplaat_Wander(LowVoiceSplaat lowvoice) : base(lowvoice)
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
