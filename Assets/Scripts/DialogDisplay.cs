using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogDisplay : MonoBehaviour
{
    public static DialogDisplay Instance { get; private set; }

	[SerializeField] private Animator dialogAnimator;
	[SerializeField] private TMP_Text dialogText;
	[SerializeField] private TMP_Text speakerNameText;
	[SerializeField] private RawImage portraitImage;

	private void Awake()
	{
		Instance = this;
	}

	public void SetDisplay(string speaker, string msg, RenderTexture img)
	{
		dialogAnimator.SetInteger("state", 1);
		speakerNameText.text = speaker;
		dialogText.text = msg;
		portraitImage.texture = img;
	}

	public void HideDisplay()
	{
		dialogAnimator.SetInteger("state", 0);
	}
}
