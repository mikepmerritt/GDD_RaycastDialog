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
        if (Physics.Raycast(camTransform.position, camTransform.forward, out RaycastHit hit))
        {
            Debug.Log(hit.collider.gameObject.name);
        }
    }
  
}
