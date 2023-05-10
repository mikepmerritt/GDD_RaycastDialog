using System;
using UnityEngine;

[Serializable]
public class Dialog
{
	public enum dialogAnimationEnum
	{
		idle,
		talk,
		confused
	}
	public string Name;
	public Animator targetAnimator;
	public RenderTexture PortraitImage;
	public string[] Message;
	public dialogAnimationEnum animation;
}