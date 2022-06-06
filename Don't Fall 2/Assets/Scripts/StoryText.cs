using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StoryText : MonoBehaviour
{
	Text _text;
	public TMP_Text _tmpProText;
	
	public string writer;
	public bool writerEnd = false;
	[SerializeField] float delayBeforeStart = 0f;
	[SerializeField] float timeBtwChars = 0.1f;
	[SerializeField] string leadingChar = "";
	[SerializeField] bool leadingCharBeforeDelay = false;
	RectTransform rec;
	// Use this for initialization
	void Start()
	{
		_text = GetComponent<Text>()!;
		_tmpProText = GetComponent<TMP_Text>()!;
		rec = GetComponent<RectTransform>();
		//rec = 

	}
	public void Writer()
    {
		
			StartCoroutine("TypeWriterTMP");
		
	}

	public void CenterTextBox()
    {
		_tmpProText.rectTransform.anchoredPosition = new Vector2(10f, 340f); 
    }
	public void UnderTextBox()
    {
		_tmpProText.rectTransform.anchoredPosition = new Vector2(-3.35f, 78f);
	}


	IEnumerator TypeWriterTMP()
	{
		

		yield return new WaitForSeconds(delayBeforeStart);

		foreach (char c in writer)
		{
			writerEnd = false;
			if (_tmpProText.text.Length > 0)
			{
				_tmpProText.text = _tmpProText.text.Substring(0, _tmpProText.text.Length - leadingChar.Length);
			}
			_tmpProText.text += c;
			_tmpProText.text += leadingChar;
			yield return new WaitForSeconds(timeBtwChars);
			writerEnd = true;
		}

		if (leadingChar != "")
		{
			_tmpProText.text = _tmpProText.text.Substring(0, _tmpProText.text.Length - leadingChar.Length);
		}
	}
}