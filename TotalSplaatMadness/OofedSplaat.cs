using MTM101BaldAPI.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TotalSplaatMadness
{
    public class OofedSplaat : NPC
    {
        public Sprite oofedSplaatSprite;
        public SoundObject oofedKlaskyCsupo;

        public override void Initialize()
        {
            base.Initialize();

            spriteRenderer[0].sprite = oofedSplaatSprite;

            AudioManager audioManager = GetComponent<AudioManager>();
            PropagatedAudioManager oofedKlaskyCsupoPlayer = base.gameObject.AddComponent<PropagatedAudioManager>();
            oofedKlaskyCsupoPlayer.audioDevice = base.gameObject.AddComponent<AudioSource>();
            oofedKlaskyCsupoPlayer.ReflectionSetVariable("soundOnStart", new SoundObject[] { oofedKlaskyCsupo });
            oofedKlaskyCsupoPlayer.ReflectionSetVariable("loopOnStart", true);

            behaviorStateMachine.ChangeState(new OofedSplaat_Wander(this));
        }
    }

    public class OofedSplaat_StateBase : NpcState
    {
        protected OofedSplaat oofedSplaat;

        public OofedSplaat_StateBase(OofedSplaat oof) : base(oof)
        {
            oofedSplaat = oof;
        }
    }

    public class OofedSplaat_Wander : OofedSplaat_StateBase
    {
        public OofedSplaat_Wander(OofedSplaat oof) : base(oof)
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
