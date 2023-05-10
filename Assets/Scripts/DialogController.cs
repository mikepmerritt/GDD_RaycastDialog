using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogController : MonoBehaviour
{
    [SerializeField] private List<Dialog> dialogList = new List<Dialog>();
    
    private int dialogListIndex;
    private int dialogMsgIndex;

	private void Start()
	{
        Activate(); //TODO: Remove 
	}

	private void Update()
	{
        if (Input.GetKeyDown(KeyCode.Space))
            NextDialog();
	}

	public void Activate()
	{
        dialogListIndex = 0;
        dialogListIndex = 0;
        NextDialog();
        PlayerMovement.Instance.SetCanMove(false);
	}

    public void NextDialog()
	{
        if(dialogListIndex >= dialogList.Count)
		{
            Deactivate();
            return;
		}

        Dialog d = dialogList[dialogListIndex];

        

        DialogDisplay.Instance.SetDisplay(d.Name, d.Message[dialogMsgIndex], d.PortraitImage);
		if (d.targetAnimator)
		{
            Debug.Log($"Playing {d.targetAnimator.gameObject.name} {d.animation.ToString()}");
            d.targetAnimator.SetInteger("state", (int)d.animation);
            d.targetAnimator.SetTrigger("change");
        }

        if (d.Message.Length > 0)
        {
            dialogMsgIndex++;
            if (dialogMsgIndex >= d.Message.Length)
            {
                dialogMsgIndex = 0;
                dialogListIndex++;
            }
            return;
        }
        
        dialogListIndex++;
    }

    public void Deactivate()
	{
        DialogDisplay.Instance.HideDisplay();
        PlayerMovement.Instance.SetCanMove(true);
    }
}
