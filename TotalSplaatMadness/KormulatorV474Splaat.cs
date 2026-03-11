using MTM101BaldAPI.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TotalSplaatMadness
{
    public class KormulatorV474Splaat : NPC
    {
        public Sprite kormulator474SplaatSprite;
        public SoundObject kormulator474KlaskyCsupo;

        public override void Initialize()
        {
            base.Initialize();

            spriteRenderer[0].sprite = kormulator474SplaatSprite;

            AudioManager audioManager = GetComponent<AudioManager>();
            PropagatedAudioManager kormulator474KlaskyCsupoPlayer = base.gameObject.AddComponent<PropagatedAudioManager>();
            kormulator474KlaskyCsupoPlayer.audioDevice = base.gameObject.AddComponent<AudioSource>();
            kormulator474KlaskyCsupoPlayer.ReflectionSetVariable("soundOnStart", new SoundObject[] { kormulator474KlaskyCsupo });
            kormulator474KlaskyCsupoPlayer.ReflectionSetVariable("loopOnStart", true);

            behaviorStateMachine.ChangeState(new KormulatorV474Splaat_Wander(this));
        }
    }

    public class KormulatorV474Splaat_StateBase : NpcState
    {
        protected KormulatorV474Splaat kormulatorV474Splaat;

        public KormulatorV474Splaat_StateBase(KormulatorV474Splaat korm474) : base(korm474)
        {
            kormulatorV474Splaat = korm474;
        }
    }

    public class KormulatorV474Splaat_Wander : KormulatorV474Splaat_StateBase
    {
        public KormulatorV474Splaat_Wander(KormulatorV474Splaat korm474) : base(korm474)
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
