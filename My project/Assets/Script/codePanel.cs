using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codePanel : MonoBehaviour
{
	[SerializeField] GameObject BoxOpenImage;
	[SerializeField]
	Text codeText;
	string codeTextValue = "";

	bool correct;
	// Update is called once per frame
	void Update()
	{
		codeText.text = codeTextValue;

		if (codeTextValue == "4279")
		{
			unlock();
		}

		if (codeTextValue.Length >= 4)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}

	public void unlock()
    {
		Debug.Log("yey");
		BoxOpenImage.SetActive(true);
		//this.transform.localPosition = new Vector2(-2123, 1525);
	}
}
