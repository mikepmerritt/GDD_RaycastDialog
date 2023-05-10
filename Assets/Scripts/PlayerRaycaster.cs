using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRaycaster : MonoBehaviour
{
    [SerializeField] private Transform camTransform;
	[SerializeField] private Image crosshair;

	private void Update()
	{
		if(Physics.Raycast(camTransform.position, camTransform.forward, out RaycastHit hit))
		{
			DialogController d = hit.collider.GetComponent<DialogController>();
			if (d)
			{
				Crosshair(true);
				if (Input.GetMouseButtonDown(0)) { d.Activate(); }
				
			}
			else
			{
				Crosshair(false);
			}
		}
		else
		{
			Crosshair(false);
		}
	}

	private void Crosshair(bool hit)
	{
		crosshair.color = Color.Lerp(crosshair.color, hit ? Color.green : Color.gray, Time.deltaTime * 4f);
		if (hit)
		{
			crosshair.transform.localScale = Vector3.one * (1.4f + Mathf.Sin(Time.time*4f) * 0.2f);
		}
	}
}
