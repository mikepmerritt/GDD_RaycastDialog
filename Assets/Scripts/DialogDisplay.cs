using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogDisplay : MonoBehaviour
{
    public static DialogDisplay Instance { get; private set; }

	[SerializeField] private TMP_Text dialogText;
	[SerializeField] private RawImage portraitImage;

    public void SetDisplay(string msg, RawImage img)
	{
		dialogText.text = msg;
		portraitImage = img;
	}
}
