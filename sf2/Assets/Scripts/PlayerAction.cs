using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerAction : MonoBehaviour
{
    Rigidbody2D rigid;

    [Tooltip("HitBox")]
    [SerializeField]
    public GameObject breaking_the_collarbone;
    public GameObject pit_of_the_stomach;
    public GameObject oryugen;
    public GameObject strong_addaddaddugen;
    public GameObject middle_addaddaddugen;
    public GameObject DownKick;
    public GameObject SitRightpunch;
    public GameObject SitLeftPunch;
    public GameObject LeftKick;
    public GameObject LeftPunch;
    public GameObject SitRightKick;
    public GameObject LeftUpperCut;
    public GameObject RightKneeKick;
    public GameObject RightPunch;
    public GameObject SitLeftKick;

    public GameObject Idle_Jump_HitBox;
    public GameObject SitDown_HitBox;
    
    public GameObject Adogen;

    [SerializeField]
    public float Speed;
    public float JumpPower;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        IdleAction();
        SitDownAction();
    }
    void IdleAction()
    {
        if (PlayerControll.isIdle == true)
        {   
            //Ä¿¸Çµå
            if (Command.Skill_set == PlayerControll.status.strong_addaddaddugen)
            {
                strong_addaddaddugen.SetActive(true);
            }
            else if(Command.Skill_set == PlayerControll.status.strong_adogen /*|| Command.Skill_set == PlayerControll.status.middle_adogen*/)
            {
                StartCoroutine(CreateAdogen());
            }
            else if (Command.Skill_set == PlayerControll.status.middle_addaddaddugen)
            {
                middle_addaddaddugen.SetActive(true);
            }
            else if (Command.Skill_set == PlayerControll.status.breaking_the_collarbone)
            {
                breaking_the_collarbone.SetActive(true);
            }
            else if (Command.Skill_set == PlayerControll.status.pit_of_the_stomach)
            {
                pit_of_the_stomach.SetActive(true);
            }
            else if (Command.Skill_set == PlayerControll.status.oryugen)
            {
                oryugen.SetActive(true);
            }
            else if(Input.GetKeyDown(KeyCode.U))
            { 
                LeftPunch.SetActive(true);
            }
            else if (Input.GetKeyDown(KeyCode.I))
            {
                RightPunch.SetActive(true);
            }
            else if (Input.GetKeyDown(KeyCode.J))
            {
                LeftKick.SetActive(true);
            }
            else if (Input.GetKeyDown(KeyCode.K))
            {
                RightKneeKick.SetActive(true);
            }
        }
    }
    void SitDownAction()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            LeftUpperCut.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            SitRightpunch.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            SitLeftKick.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            SitRightKick.SetActive(true);
        }
    }

    IEnumerator CreateAdogen()
    {
        yield return new WaitForSeconds(0.7f);
        Instantiate(Adogen, new Vector3(rigid.position.x + 1.7f, rigid.position.y + 0.77f, 0), Quaternion.identity);
    }
}