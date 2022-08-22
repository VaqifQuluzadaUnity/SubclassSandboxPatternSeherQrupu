using UnityEngine;

public class CharacterCombatController : MonoBehaviour
{
	[SerializeField] private AudioSource spellSfxSource;

	[SerializeField] private Animator characterAnimator;
	public void CastMagic(GameObject spell)
	{
			GameObject spellInstance = Instantiate(spell);


		spellInstance.GetComponent<MagicSpell>().Setup(characterAnimator,spellSfxSource,transform);

		spellInstance.GetComponent<MagicSpell>().Cast();

		
	}
}
