using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command : MonoBehaviour
{
    float CommandTime = 1f;
    private Queue<string> inputQueue = new Queue<string>();
    
    public static PlayerControll.status Skill_set;
    void Start()
    {
        Skill_set = GetComponent<PlayerControll>().state;
    }

    void Update()
    {
        CommandTime -= Time.deltaTime;

        if(CommandTime <= 0)
        {
            inputQueue.Clear();
        }

        if(Input.GetKeyDown(KeyCode.U) || Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.K)
        || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            CommandTime = 1f;
        }

        if (Input.GetKeyDown(KeyCode.U) || Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.K))
        {
            string input = GetValidCommandKey(Input.inputString);
            CheckQueue(input);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            string input = "4";
            CheckQueue(input);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            string input = "6";
            CheckQueue(input);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            string input = "8";
            CheckQueue(input);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            string input = "2";
            CheckQueue(input);
        }
    }
    private string GetValidCommandKey(string input)
    {
        if (input == "u")
        {
            return "A";
        }
        else if (input == "i")
        {
            return "B";
        }
        else if (input == "j")
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
        string commandSequence = string.Join("", inputQueue.ToArray());
        if (inputQueue.Count >= 4)
        {
            if (commandSequence.Contains("646C"))
            {
                Skill_set = PlayerControll.status.oryugen;
                Debug.Log("Oryugen");
                inputQueue.Clear();
            }
            else
            {
                inputQueue.Dequeue();
            }
        }
        else if (inputQueue.Count >= 3)
        {

            if (commandSequence.Contains("26A"))
            {
                Skill_set = PlayerControll.status.middle_adogen;
                Debug.Log("middle_Adogen");
                inputQueue.Clear();
            }
            else if (commandSequence.Contains("26C"))
            {
                Skill_set = PlayerControll.status.strong_adogen;
                Debug.Log("strong_Adogen");
                inputQueue.Clear();
            }
            else if (commandSequence.Contains("24D"))
            {
                Skill_set = PlayerControll.status.strong_addaddaddugen;
                Debug.Log("Strong_Addaddaddugen");
                inputQueue.Clear();
            }
            else if (commandSequence.Contains("24B"))
            {
                Skill_set = PlayerControll.status.middle_addaddaddugen;
                Debug.Log("Middle_Addaddaddugen");
                inputQueue.Clear();
            }
            else
            {
                inputQueue.Dequeue();
            }
        }
        else if (inputQueue.Count >= 2)
        {
            if (commandSequence.Contains("6A"))
            {
                Skill_set = PlayerControll.status.breaking_the_collarbone;
                Debug.Log("breaking_the_collarbone");
                inputQueue.Clear();
            }
            else if (commandSequence.Contains("6C"))
            {
                Skill_set = PlayerControll.status.pit_of_the_stomach;
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
            if (Input.GetKey(KeyCode.U) || Input.GetKey(KeyCode.I) || Input.GetKey(KeyCode.J) || Input.GetKey(KeyCode.K))
            {
                CheckCommand();
            }
        }
    }
}