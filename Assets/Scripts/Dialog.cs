using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog
{
	public enum EmotionEnum
	{
		Default,
		Happy,
		Sad,
		Angry
	}

	public Camera PortraitCamera;
	public string[] Message;
	public EmotionEnum Emotion;
}