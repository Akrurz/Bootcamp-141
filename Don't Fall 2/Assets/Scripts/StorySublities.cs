using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StorySublities : MonoBehaviour
{
    public bool filled = true;
    [SerializeField]
    Image renderer;
    [SerializeField] GameObject storyPanel;
    [SerializeField] int i = 0;
    [SerializeField] Sprite[] storySprites;
    UiManager manager;
    public string[] _stroyTextSublities = {
        "The Radient Experiment Will Have An Important Consequences For Humanity...",
        "We Couldn't Reach Our Researcher For 5 Days Hope He's Okay...",
        "In The Last Message We Received, He Said That He Was Progressing On The Experiment",
        "The Radient Experiment Is A Research On Preveting Global Warnimg In The World",
        "The Laboratry Is Hidden On An Island, Because It Is A Secret Experiment. But It Is An Event That Will Affect Humanity",
        "But It Is An Event That Will Affect Humanity",
        "It's Gonna Be A Long Journey Boys... Keep Your Energy To Down There",
        "We Don't Know What Is Waýtýng For Us In The Island",
        "The Only Thing I Know Is We Have Find A Man Who Can Save Our Lives",
        "Dr.June, His Assistant And The Pilot Is A Team Assigned To Control The Researcher On The Island",
        "Because The Researcher Could Not Be Contacted For 5 Days.",
        "It Is A State Of Concern.",
        "Because He Transmitted The Research Results To The Headquarters Every Day Until 5 Days Ago...",
        "There Are So Many Missing Pieces In This Map",
        "Don't Worry, You Got This Dr.June",
        "Let's Try To Find The Marked Place Until Sunset When We Land",
        "What' Going On ?!?",
        "We Have A Problem On The Back, Hold Tight!!",
        "I Can't Control This Anymore!!",
        "Dr.June, His Assistant And The Pilot Had An Accident This Day.",
        "Dr.June Was Alone On This Island And Mission Now..."

    };
    StoryText _storyText;


    void Awake()
    {
        _storyText = GetComponent<StoryText>();
        manager = FindObjectOfType<UiManager>();
        //StoryManager();
        //renderer = GetComponent<SpriteRenderer>();


    }

    public void ChecBox()
    {
        if (_storyText._tmpProText.text.Length >= 0)
        {
            i = 0;
            StoryManager();

        }

    }

    public void StoryManager()
    {
        switch (i)
        {
            case 0:
                _storyText.UnderTextBox();
                _storyText._tmpProText.text = "";
                _storyText.writer = _stroyTextSublities[0];
                renderer.sprite = storySprites[0];
                _storyText.Writer();
                break;
            case 1:
                _storyText._tmpProText.text = "";
                _storyText.writer = _stroyTextSublities[1];
                renderer.sprite = storySprites[1];
                _storyText.Writer();
                break;
            case 2:
                _storyText._tmpProText.text = "";
                _storyText.UnderTextBox();
                _storyText.writer = _stroyTextSublities[2];
                renderer.sprite = storySprites[2];
                _storyText.Writer();
                break;
            case 3:
                _storyText._tmpProText.text = "";
                _storyText.CenterTextBox();
                _storyText.writer = _stroyTextSublities[3];
                renderer.sprite = storySprites[3];
                _storyText.Writer();
                break;
            case 4:
                _storyText._tmpProText.text = "";
                _storyText.writer = _stroyTextSublities[4];
                renderer.sprite = storySprites[3];
                _storyText.Writer();
                break;
            case 5:
                _storyText._tmpProText.text = "";
                _storyText.writer = _stroyTextSublities[5];
                renderer.sprite = storySprites[3];
                _storyText.Writer();
                break;
            case 6:
                _storyText._tmpProText.text = "";
                _storyText.UnderTextBox();
                _storyText.writer = _stroyTextSublities[6];
                renderer.sprite = storySprites[4];
                _storyText.Writer();
                break;
            case 7:
                _storyText._tmpProText.text = "";
                _storyText.writer = _stroyTextSublities[7];
                renderer.sprite = storySprites[5];
                _storyText.Writer();
                break;
            case 8:
                _storyText._tmpProText.text = "";
                _storyText.writer = _stroyTextSublities[8];
                renderer.sprite = storySprites[6];
                _storyText.Writer();
                break;
            case 9:
                _storyText._tmpProText.text = "";
                _storyText.CenterTextBox();
                _storyText.writer = _stroyTextSublities[9];
                renderer.sprite = storySprites[7];
                _storyText.Writer();
                break;
            case 10:
                _storyText._tmpProText.text = "";
                _storyText.writer = _stroyTextSublities[10];
                renderer.sprite = storySprites[7];
                _storyText.Writer();
                break;
            case 11:
                _storyText._tmpProText.text = "";
                _storyText.writer = _stroyTextSublities[11];
                renderer.sprite = storySprites[7];
                _storyText.Writer();
                break;
            case 12:
                _storyText._tmpProText.text = "";
                _storyText.writer = _stroyTextSublities[12];
                renderer.sprite = storySprites[7];
                _storyText.Writer();
                break;
            case 13:
                _storyText._tmpProText.text = "";
                _storyText.UnderTextBox();
                _storyText.writer = _stroyTextSublities[13];
                renderer.sprite = storySprites[8];
                _storyText.Writer();
                break;
            case 14:
                _storyText._tmpProText.text = "";
                _storyText.writer = _stroyTextSublities[14];
                renderer.sprite = storySprites[8];
                _storyText.Writer();
                break;
            case 15:
                _storyText._tmpProText.text = "";
                _storyText.writer = _stroyTextSublities[15];
                renderer.sprite = storySprites[9];
                _storyText.Writer();
                break;
            case 16:
                _storyText._tmpProText.text = "";
                _storyText.writer = _stroyTextSublities[16];
                renderer.sprite = storySprites[10];
                _storyText.Writer();
                break;
            case 17:
                _storyText._tmpProText.text = "";
                _storyText.writer = _stroyTextSublities[17];
                renderer.sprite = storySprites[10];
                _storyText.Writer();
                break;
            case 18:
                _storyText._tmpProText.text = "";
                _storyText.writer = _stroyTextSublities[18];
                renderer.sprite = storySprites[11];
                _storyText.Writer();
                break;
            case 19:
                _storyText.UnderTextBox();
                _storyText._tmpProText.text = "";
                renderer.sprite = storySprites[12];
                break;
            case 20:
                _storyText._tmpProText.text = "";
                _storyText.CenterTextBox();
                _storyText.writer = _stroyTextSublities[19];
                renderer.sprite = storySprites[13];
                _storyText.Writer();
                break;
            case 21:
                _storyText._tmpProText.text = "";
                _storyText.CenterTextBox();
                _storyText.writer = _stroyTextSublities[20];
                renderer.sprite = storySprites[13];
                _storyText.Writer();
                break;
            default:
                break;
        }
    }

    public void NexText()
    {

        if (_storyText.writerEnd)
        {
            i = i + 1;
            if (i > 21)
            {
                i = 0;
                manager.Back();
            }
            else
            {
                StoryManager();
            }


        }

    }

    public void PreviousText()
    {
        if (_storyText.writerEnd)
        {

            i = i - 1;
            if (i < 0)
            {
                manager.Back();
            }
            else
            {
                StoryManager();
            }


        }
    }

}
