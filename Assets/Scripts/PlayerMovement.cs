using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public static PlayerMovement Instance { get; private set; }

	[SerializeField] private CharacterController controller;
	[SerializeField] private Transform cameraTransform;
	[SerializeField] private float walkSpeed;
	[Range(0f,1f)] [SerializeField] private float drag;
	[SerializeField] private float mouseSensitivityX;
	[SerializeField] private float mouseSensitivityY;

	private Vector3 velocity;
	private bool canMove;

	private void Awake()
	{
		Instance = this;
	}

	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		canMove = true;
	}

	private void Update()
	{
		if (canMove)
		{
			//Movement
			float run = Input.GetKey(KeyCode.LeftShift) ? 1.5f : 1f;
			velocity = Vector3.Lerp(velocity, transform.forward * Input.GetAxis("Vertical") + transform.right * Input.GetAxis("Horizontal"), Time.deltaTime * walkSpeed * run);
			velocity *= (1f - drag);
			controller.Move(velocity);
		}
		//Rotation
		transform.Rotate(transform.up, Input.GetAxis("Mouse X") * mouseSensitivityX);

		float rot = -Input.GetAxis("Mouse Y") * mouseSensitivityY;
		cameraTransform.localEulerAngles = new Vector3(cameraTransform.localEulerAngles.x + rot, 0, 0);
	}

	public void SetCanMove(bool can)
	{
		canMove = can;
	}
}
