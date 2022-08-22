using UnityEngine;

public class MagicSpell : MonoBehaviour
{
	public string animationStateName;

	public Animator animatorComponent;

	public AudioClip spellSfx;

	public AudioSource spellSFXSource;

	public GameObject spellVfx;

	public Transform targetTransform;

	public virtual void Cast()
	{

	}

	public virtual void PlaySound()
	{
		
	}

	public virtual void PlayAnimation()
	{
		
	}

	public virtual void Effect()
	{

	}

	public virtual void SpawnParticle()
	{
		GameObject particleInstance = Instantiate(spellVfx, targetTransform);
	}

	public void Setup(Animator animator, AudioSource sfxSource,Transform particleTransform)
	{
		animatorComponent = animator;

		spellSFXSource = sfxSource;

		targetTransform = particleTransform;
	}
}
