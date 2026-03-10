using MTM101BaldAPI.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TotalSplaatMadness
{
    public class FormulatorV975Splaat : NPC // correct name is 4ormulator V975 Splaat. the class name has formulator instead of 4ormulator due to c# limitations
    {
        public Sprite formulator975SplaatSprite;
        public SoundObject formulator975KlaskyCsupo;

        public override void Initialize()
        {
            base.Initialize();

            spriteRenderer[0].sprite = formulator975SplaatSprite;

            AudioManager audioManager = GetComponent<AudioManager>();
            PropagatedAudioManager formulator975KlaskyCsupoPlayer = base.gameObject.AddComponent<PropagatedAudioManager>();
            formulator975KlaskyCsupoPlayer.audioDevice = base.gameObject.AddComponent<AudioSource>();
            formulator975KlaskyCsupoPlayer.ReflectionSetVariable("soundOnStart", new SoundObject[] { formulator975KlaskyCsupo });
            formulator975KlaskyCsupoPlayer.ReflectionSetVariable("loopOnStart", true);

            behaviorStateMachine.ChangeState(new FormulatorV975Splaat_Wander(this));
        }
    }

    public class FormulatorV975Splaat_StateBase : NpcState
    {
        protected FormulatorV975Splaat formulatorV975Splaat;

        public FormulatorV975Splaat_StateBase(FormulatorV975Splaat form975) : base(form975)
        {
            formulatorV975Splaat = form975;
        }
    }

    public class FormulatorV975Splaat_Wander : FormulatorV975Splaat_StateBase
    {
        public FormulatorV975Splaat_Wander(FormulatorV975Splaat form975) : base(form975)
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
