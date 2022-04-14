using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codePanel : MonoBehaviour	// codePanel for the Saftybox
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

		if (codeTextValue == "4279")	// If player wnter 4279, the Saftybox will open
		{
			unlock();
		}

		if (codeTextValue.Length >= 4)
        {
			codeTextValue = "";		// codePanel will be restared when player put wrong 4 digits 
		}
			
	}

	public void AddDigit(string digit)
	{
		AudioManager.instance.Play("PressBotton");	// Play the sound effect when player enter digits
		codeTextValue += digit;
	}

	public void unlock()
    {
		AudioManager.instance.Play("BoxUnlock");    // Play the sound effect when player open the saftybox
		BoxOpenImage.SetActive(true);
	}
}
