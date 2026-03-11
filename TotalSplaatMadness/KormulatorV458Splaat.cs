using MTM101BaldAPI.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TotalSplaatMadness
{
    public class KormulatorV458Splaat : NPC
    {
        public Sprite kormulator458SplaatSprite;
        public SoundObject kormulator458KlaskyCsupo;

        public override void Initialize()
        {
            base.Initialize();

            spriteRenderer[0].sprite = kormulator458SplaatSprite;

            AudioManager audioManager = GetComponent<AudioManager>();
            PropagatedAudioManager kormulator458KlaskyCsupoPlayer = base.gameObject.AddComponent<PropagatedAudioManager>();
            kormulator458KlaskyCsupoPlayer.audioDevice = base.gameObject.AddComponent<AudioSource>();
            kormulator458KlaskyCsupoPlayer.ReflectionSetVariable("soundOnStart", new SoundObject[] { kormulator458KlaskyCsupo });
            kormulator458KlaskyCsupoPlayer.ReflectionSetVariable("loopOnStart", true);

            behaviorStateMachine.ChangeState(new KormulatorV458Splaat_Wander(this));
        }
    }

    public class KormulatorV458Splaat_StateBase : NpcState
    {
        protected KormulatorV458Splaat kormulatorV458Splaat;

        public KormulatorV458Splaat_StateBase(KormulatorV458Splaat korm458) : base(korm458)
        {
            kormulatorV458Splaat = korm458;
        }
    }

    public class KormulatorV458Splaat_Wander : KormulatorV458Splaat_StateBase
    {
        public KormulatorV458Splaat_Wander(KormulatorV458Splaat korm458) : base(korm458)
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
