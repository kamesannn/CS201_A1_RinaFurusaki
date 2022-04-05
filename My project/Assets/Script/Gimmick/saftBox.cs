using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saftBox : MonoBehaviour
{
	Rigidbody2D rb;
	//float moveSpeed = 5f, dirX;

	[SerializeField]
	GameObject codePanel, closedSafe, openedSafe;

	public static bool isSafeOpened = false;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		codePanel.SetActive(false);
		closedSafe.SetActive(true);
		openedSafe.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
		//dirX = Input.GetAxis("Horizontal") * moveSpeed;

		if (isSafeOpened)
		{
			codePanel.SetActive(false);
			closedSafe.SetActive(false);
			openedSafe.SetActive(true);
		}
	}

	//void fixedupdate()
	//{
	//	rb.velocity = new vector2(dirx, rb.velocity.y);
	//}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name.Equals("Safe") && !isSafeOpened)
		{
			codePanel.SetActive(true);
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.name.Equals("Safe"))
		{
			codePanel.SetActive(false);
		}
	}
}
