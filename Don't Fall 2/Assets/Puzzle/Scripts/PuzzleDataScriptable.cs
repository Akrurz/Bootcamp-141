using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestionsData", menuName = "QuestionsData", order = 1)]
public class PuzzleDataScriptable : ScriptableObject
{
    public List<QuestionData> questions;
}
