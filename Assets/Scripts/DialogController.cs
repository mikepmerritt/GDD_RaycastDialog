using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogController : MonoBehaviour
{
    [SerializeField] private List<Dialog> dialogList = new List<Dialog>();
    
    private int dialogListIndex;

    public void Activate()
	{
        dialogListIndex = 0;
	}
}
