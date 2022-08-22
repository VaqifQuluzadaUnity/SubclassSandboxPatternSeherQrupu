using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScaleChanger : MonoBehaviour
{
  [SerializeField] private CanvasScaler canvasScaler;

	private void Start()
	{
		canvasScaler.referenceResolution = new Vector2(Screen.width,Screen.height);
	}
}
