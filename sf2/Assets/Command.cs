using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command : MonoBehaviour
{
    private Queue<string> inputQueue = new Queue<string>();
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.D))
        {
            string input = GetValidCommandKey(Input.inputString);
            CheckQueue(input);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            string input = "°Á";
            CheckQueue(input);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            string input = "°Ê";
            CheckQueue(input);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            string input = "°Ë";
            CheckQueue(input);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            string input = "°È";
            CheckQueue(input);
        }
    }
    private string GetValidCommandKey(string input)
    {
        if (input == "a")
        {
            return "A";
        }
        else if (input == "b")
        {
            return "B";
        }
        else if (input == "c")
        {
            return "C";
        }
        else if (input == "d")
        {
            return "D";
        }
        else
        {
            return null;
        }
    }
    private void CheckCommand()
    {
        //if (inputQueue.Count >= 2)
        //{
        //    string commandsequence = string.Join("", inputQueue.ToArray());

        //    if (commandsequence.Contains("°Êa"))
        //    {
        //        Debug.Log("breaking_the_collarbone");
        //        inputQueue.Clear();
        //    }
        //    else if (commandsequence.Contains("°Êc"))
        //    {
        //        Debug.Log("pit_of_the_stomach");
        //        inputQueue.Clear();
        //    }
        //    else
        //    {
        //        inputQueue.Dequeue();
        //    }
        //}

        if (inputQueue.Count >= 3)
        {
            string commandSequence = string.Join("", inputQueue.ToArray());
            
            if (commandSequence.Contains("°È°ÊA"))
            {
                Debug.Log("middle_Adogen");
                inputQueue.Clear();
            }
            if (commandSequence.Contains("°È°ÊC"))
            {
                Debug.Log("strong_Adogen");
                inputQueue.Clear();
            }
            if (commandSequence.Contains("°È°ÁD"))
            {
                Debug.Log("strong_Adogen");
                inputQueue.Clear();
            }
            if (commandSequence.Contains("°È°ÁB"))
            {
                Debug.Log("strong_Adogen");
                inputQueue.Clear();
            }
            if (commandSequence.Contains("°Ê°Á°ÊC"))
            {
                Debug.Log("Oryugen");
                inputQueue.Clear();
            }
            if (commandSequence.Contains("°Ê°Á°ÊA"))
            {
                Debug.Log("Weak_Oryugen");
                inputQueue.Clear();
            }
            else
            {
                inputQueue.Dequeue();
            }
        }

        //else if (inputQueue.Count >= 4)
        //{
        //    string commandSequence = string.Join("", inputQueue.ToArray());
        //    if (commandSequence.Contains("°Ê°Á°ÊA"))
        //    {
        //        Debug.Log("Weak_Oryugen");
        //        inputQueue.Clear();
        //    }
        //    if (commandSequence.Contains("°Ê°Á°ÊC"))
        //    {
        //        Debug.Log("Oryugen");
        //        inputQueue.Clear();
        //    }
        //}

        //else if (inputQueue.Count >= 5)
        //{
        //    string commandSequence = string.Join("", inputQueue.ToArray());

        //    if (commandSequence.Contains("°È°Ê°È°ÊC"))
        //    {
        //        Debug.Log("Sinkuadogen");
        //        inputQueue.Clear();
        //    }
        //    else if (commandSequence.Contains("°È°Ê°È°ÊA"))
        //    {
        //        Debug.Log("Weak_Sinkuadogen");
        //        inputQueue.Clear();
        //    }
        //    else
        //    {
        //        inputQueue.Dequeue();
        //    }
        //}
    }
    void CheckQueue(string input)
    {
        if (!string.IsNullOrEmpty(input))
        {
            inputQueue.Enqueue(input);
            CheckCommand();
        }
    }
}
