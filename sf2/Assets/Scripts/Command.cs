using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command : MonoBehaviour
{
    float CommandTime = 1f;
    private Queue<string> inputQueue = new Queue<string>();
    PlayerControll.status SkillState;
    void Start()
    {
        
    }

    void Update()
    {
        CommandTime -= Time.deltaTime;

        if(CommandTime <= 0)
        {
            inputQueue.Dequeue();
        }

        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.D)
        || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            CommandTime = 1f;
        }

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
        string commandSequence = string.Join("", inputQueue.ToArray());
        if (inputQueue.Count >= 5)
        {
            if (commandSequence.Contains("�����C"))
            {
                Debug.Log("Sinkuadogen");
                inputQueue.Clear();
            }
            else if (commandSequence.Contains("�����A"))
            {
                Debug.Log("Weak_Sinkuadogen");
                inputQueue.Clear();
            }
            else
            {
                inputQueue.Dequeue();
            }
        }
        else if (inputQueue.Count >= 4)
        {
            if (commandSequence.Contains("����A"))
            {
                Debug.Log("Weak_Oryugen");
                inputQueue.Clear();
            }
            else if (commandSequence.Contains("����C"))
            {
                Debug.Log("Oryugen");
                inputQueue.Clear();
            }
        }
        else if (inputQueue.Count >= 3)
        {

            if (commandSequence.Contains("���A"))
            {
                Debug.Log("middle_Adogen");
                inputQueue.Clear();
            }
            else if (commandSequence.Contains("���C"))
            {
                Debug.Log("strong_Adogen");
                inputQueue.Clear();
            }
            else if (commandSequence.Contains("���D"))
            {
                Debug.Log("strong_Adogen");
                inputQueue.Clear();
            }
            else if (commandSequence.Contains("���B"))
            {
                Debug.Log("strong_Adogen");
                inputQueue.Clear();
            }
            else if (commandSequence.Contains("����C"))
            {
                Debug.Log("Oryugen");
                inputQueue.Clear();
            }
            else if (commandSequence.Contains("����A"))
            {
                Debug.Log("Weak_Oryugen");
                inputQueue.Clear();
            }
            else
            {
                inputQueue.Dequeue();
            }
        }
        else if (inputQueue.Count >= 2)
        {
            if (commandSequence.Contains("��A"))
            {
                Debug.Log("breaking_the_collarbone");
                inputQueue.Clear();
            }
            else if (commandSequence.Contains("��C"))
            {
                Debug.Log("pit_of_the_stomach");
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
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.B) || Input.GetKey(KeyCode.C) || Input.GetKey(KeyCode.D))
            {
                CheckCommand();
            }
        }
    }
}
