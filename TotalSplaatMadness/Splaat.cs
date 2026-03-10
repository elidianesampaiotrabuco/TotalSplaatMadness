using MTM101BaldAPI.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TotalSplaatMadness
{
    public class Splaat : NPC
    {
        public Sprite normalSplaatSprite;
        public SoundObject normalKlaskyCsupo;

        public override void Initialize()
        {
            base.Initialize();

            spriteRenderer[0].sprite = normalSplaatSprite;

            AudioManager audioManager = GetComponent<AudioManager>();
            PropagatedAudioManager klaskyCsupoPlayer = base.gameObject.AddComponent<PropagatedAudioManager>();
            klaskyCsupoPlayer.audioDevice = base.gameObject.AddComponent<AudioSource>();
            klaskyCsupoPlayer.ReflectionSetVariable("soundOnStart", new SoundObject[] { normalKlaskyCsupo });
            klaskyCsupoPlayer.ReflectionSetVariable("loopOnStart", true);

            behaviorStateMachine.ChangeState(new Splaat_Wander(this));
        }
    }

    public class Splaat_StateBase : NpcState
    {
        protected Splaat normalSplaat;

        public Splaat_StateBase(Splaat klasky) : base(klasky)
        {
            normalSplaat = klasky;
        }
    }

    public class Splaat_Wander : Splaat_StateBase
    {
        public Splaat_Wander(Splaat klasky) : base(klasky)
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
