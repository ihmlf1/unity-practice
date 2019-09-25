﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diagoluemanager : MonoBehaviour
{
    public Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }
    public void Stardialogue(Dialogue dialogue)
    {
        Debug.Log("this is"+dialogue.name+" speaking");
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
    }
    void EndDialogue()
    {
        Debug.Log("endofsentence");
    }

}
