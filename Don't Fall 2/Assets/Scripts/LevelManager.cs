using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class LevelManager : MonoBehaviour
{
    [SerializeField] Sprite[] images;
    [SerializeField] GameObject loadingScreen;
    [SerializeField] Slider slider;
    [SerializeField] Image rendererSprite;
    [SerializeField] TextMeshProUGUI loadingCalc, loadTextBox;
    [SerializeField] LoadingDrText drText;

    bool loadEvent = false;

    float currentValue;

    [SerializeField]
    [Range(0, 1)]
    float progressAnimationMultiplier = 0.25f;
    public void LoadScene(int sceneIndex)
    {

        StartCoroutine(LoadAsynchronously(sceneIndex));

    }

    void Start()
    {
        drText = GetComponent<LoadingDrText>();
        InvokeRepeating("LoadScreenSetting", 0, 3f);
        
    }
    void LoadScreenSetting()
    {
        loadingScreen.SetActive(true);
        rendererSprite.sprite = images[UnityEngine.Random.Range(0, images.Length)];
        loadTextBox.text = drText.loadText[UnityEngine.Random.Range(0, drText.loadText.Length)];
    }
    public void Update()
    {
        currentValue = Mathf.MoveTowards(currentValue, 1f, progressAnimationMultiplier * Time.deltaTime);
        int currentText = (int)(currentValue * 100);
        Debug.Log(currentValue);
        slider.value = currentText / 100f;
        loadingCalc.text = "%" + currentText.ToString();
        if (currentValue > 0.99f && !loadEvent)
        {
            loadEvent = true;
            LoadScene(1);
            //Debug.Log("ife girdi*****************");
        }




    }

    public void Active()
    {
        gameObject.SetActive(true);
    }
    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);



        while (!operation.isDone && loadEvent)
        {

            yield return null;
        }


    }

}
