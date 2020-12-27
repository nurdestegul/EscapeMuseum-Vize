using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStartInstructions : MonoBehaviour {

	private Text welcomeText;
	private Button buttonText;

	private List<string> instructions = new List<string>();
	private int i = 0;



	void Start() {
		welcomeText = GetComponentInChildren<Text>();
		buttonText = GetComponentInChildren<Button>();

		instructions.Add("Müzeye girin ve\nSanat Tarihi hakkında\nbilgiler öğrenin!");
		instructions.Add("Tablolara bakın ve\nsoruları cevaplayın.");
		instructions.Add("Hareket etmek için\nkayan toplara tıklayın.");
		instructions.Add("Bol Şanslar!");
	}


	public void OnClick() {
		if (i < instructions.Count) {
			welcomeText.text = instructions[i++];
		}

		if (i == instructions.Count) {
			buttonText.GetComponentInChildren<Text>().text = "BAŞLA!";
			i++;
		} else if (i > instructions.Count) {
			GetComponentInParent<Canvas>().enabled = false;
		}
	}
}
