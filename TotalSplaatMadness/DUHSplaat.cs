using MTM101BaldAPI.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TotalSplaatMadness
{
    public class DUHSplaat : NPC
    {
        public Sprite duhSplaatSprite;
        public SoundObject duhKlaskyCsupo;

        public override void Initialize()
        {
            base.Initialize();

            spriteRenderer[0].sprite = duhSplaatSprite;

            AudioManager audioManager = GetComponent<AudioManager>();
            PropagatedAudioManager duhKlaskyCsupoPlayer = base.gameObject.AddComponent<PropagatedAudioManager>();
            duhKlaskyCsupoPlayer.audioDevice = base.gameObject.AddComponent<AudioSource>();
            duhKlaskyCsupoPlayer.ReflectionSetVariable("soundOnStart", new SoundObject[] { duhKlaskyCsupo });
            duhKlaskyCsupoPlayer.ReflectionSetVariable("loopOnStart", true);

            behaviorStateMachine.ChangeState(new DUHSplaat_Wander(this));
        }
    }

    public class DUHSplaat_StateBase : NpcState
    {
        protected DUHSplaat duhSplaat;

        public DUHSplaat_StateBase(DUHSplaat duh) : base(duh)
        {
            duhSplaat = duh;
        }
    }

    public class DUHSplaat_Wander : DUHSplaat_StateBase
    {
        public DUHSplaat_Wander(DUHSplaat duh) : base(duh)
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
