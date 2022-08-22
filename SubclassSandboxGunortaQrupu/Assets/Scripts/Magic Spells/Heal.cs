using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MagicSpell
{
	public override void Cast()
	{
		PlayAnimation();

		//PlaySound();

		SpawnParticle();
	}

	public override void PlayAnimation()
	{
		animatorComponent.StopPlayback();
		animatorComponent.Play(animationStateName);
	}

	public override void PlaySound()
	{
		spellSFXSource.clip = spellSfx;

		spellSFXSource.Play();
	}

	public override void Effect()
	{
		//Raise Heal event
	}

}
