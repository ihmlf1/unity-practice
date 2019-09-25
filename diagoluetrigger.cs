using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diagoluetrigger : MonoBehaviour
{
    public Dialogue dialogue;
    private Queue<string> sentences = new Queue<string>();
    void Start()
    {
        Debug.Log("this is" + dialogue.name + " speaking");
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count==0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
    }
    void EndDialogue()
    {
        Debug.Log("");
    }
    public void TriggerDialogue(Dialogue dialogue)
    {
        FindObjectOfType<diagoluemanager>().Stardialogue(dialogue);
    }
}
