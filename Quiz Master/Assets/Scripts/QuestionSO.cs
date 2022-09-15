using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")] // U meniju se vidi kao Quiz Question, kad ga kreiras zove se New Question
public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] string question = "Enter new Question text here"; // Serialize field allows us set our question in the inspector, but not access it from another class
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int indexOfCorrectAnswer = 3;
    public string GetQuestion()
    {
        return question;
    }

    public int GetCorrectAnswerIndex()
    {
        return indexOfCorrectAnswer;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }
}

