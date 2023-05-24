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
            string input = "��";
            CheckQueue(input);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            string input = "��";
            CheckQueue(input);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            string input = "��";
            CheckQueue(input);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            string input = "��";
            CheckQueue(input);
        }
    }
    private string GetValidCommandKey(string input)
    {
        if (input == "u")
        {
            return "A";
        }
        else if (input == "j")
        {
            return "B";
        }
        else if (input == "i")
        {
            return "C";
        }
        else if (input == "k")
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
        if (inputQueue.Count >= 3)
        {
            string commandSequence = string.Join("", inputQueue.ToArray());

            if (commandSequence.Contains("���A"))
            {
                Debug.Log("Adogen");
                inputQueue.Clear();
            }
            else
            {
                inputQueue.Dequeue();
            }
        }
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
