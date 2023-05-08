using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private Light[] lights;
	float[] lightTargets;

	private void Start()
	{
		lightTargets = new float[lights.Length];
		for (int i = 0; i < lights.Length; i++)
		{
			lightTargets[i] = Random.Range(0.4f, 2f);
		}
	}

	private void Update()
	{
		for (int i = 0; i < lights.Length; i++)
		{
			lights[i].intensity = Mathf.Lerp(lights[i].intensity, lightTargets[i], Time.deltaTime * 5f);
		}

		if(Random.value > 0.95f)
		{
			for (int i = 0; i < lights.Length; i++)
			{
				lightTargets[i] = Random.Range(0.5f, 1f);
			}
		}
	}
}
