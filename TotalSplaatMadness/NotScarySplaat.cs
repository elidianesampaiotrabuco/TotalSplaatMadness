using MTM101BaldAPI.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TotalSplaatMadness
{
    public class NotScarySplaat : NPC
    {
        public Sprite notScarySplaatSprite;
        public SoundObject notScaryKlaskyCsupo;

        public override void Initialize()
        {
            base.Initialize();

            spriteRenderer[0].sprite = notScarySplaatSprite;

            AudioManager audioManager = GetComponent<AudioManager>();
            PropagatedAudioManager notScaryKlaskyCsupoPlayer = base.gameObject.AddComponent<PropagatedAudioManager>();
            notScaryKlaskyCsupoPlayer.audioDevice = base.gameObject.AddComponent<AudioSource>();
            notScaryKlaskyCsupoPlayer.ReflectionSetVariable("soundOnStart", new SoundObject[] { notScaryKlaskyCsupo });
            notScaryKlaskyCsupoPlayer.ReflectionSetVariable("loopOnStart", true);

            behaviorStateMachine.ChangeState(new NotScarySplaat_Wander(this));
        }
    }

    public class NotScarySplaat_StateBase : NpcState
    {
        protected NotScarySplaat notScarySplaat;

        public NotScarySplaat_StateBase(NotScarySplaat scary) : base(scary)
        {
            notScarySplaat = scary;
        }
    }

    public class NotScarySplaat_Wander : NotScarySplaat_StateBase
    {
        public NotScarySplaat_Wander(NotScarySplaat scary) : base(scary)
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
