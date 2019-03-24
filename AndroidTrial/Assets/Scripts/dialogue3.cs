﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogue3 : MonoBehaviour
{
    public bool answer1;
    public bool answer2;
    public int QuestionList1;
    public int QuestionList2;
    public GameObject AskingCanvas;
    public List<string> Reply1 = new List<string>();
    public List<string> Reply2 = new List<string>();
    public List<string> Sub1 = new List<string>();
    public List<string> Sub2 = new List<string>();
    // Start is called before the first frame update
    AnimatorScript anime;
    public void Start()
    {
        anime = GetComponentInChildren<AnimatorScript>();

    }


    public void Update()
    {
        if (answer1 == true)
        {

            
         

        }
    }

    public void EndDialogue()
    {
        print("Ending");
    }


    public void AskQuestion()
    {
        if (answer1)
        {
            GameObject.Find("Sub3").GetComponent<Text>().text = Sub1[QuestionList1];
            GameObject.Find("Text11").GetComponent<Text>().text = Reply1[QuestionList2];
            GameObject.Find("Text22").GetComponent<Text>().text = Reply2[QuestionList2];
        }
        if (answer2)
        {
            GameObject.Find("Sub3").GetComponent<Text>().text = Sub2[QuestionList2];
            GameObject.Find("Text11").GetComponent<Text>().text = Reply1[QuestionList2];
            GameObject.Find("Text22").GetComponent<Text>().text = Reply2[QuestionList2];
        }
    }

    public void reply1()
    {
        anime.Talk();
        if (QuestionList1 == 2)
            QuestionList1 = 0;

        QuestionList1 += 1;
        // QuestionList2 += 1;

        answer2 = false;
        answer1 = true;
        AskQuestion();
    }

    public void reply2()
    {
        anime.Talk();
        if (QuestionList2 == 2)
            QuestionList2 = 0;

        //QuestionList1 += 1;
        QuestionList2 += 1;

        answer2 = true;
        answer1 = false;
        AskQuestion();
    }





}
