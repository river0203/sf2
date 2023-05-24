using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerAction : MonoBehaviour
{
    Rigidbody2D rigid;

    [SerializeField]
    [Tooltip("HitBox")]
    GameObject strong_adogen;
    GameObject middle_adogen;
    GameObject breaking_the_collarbone;
    GameObject pit_of_the_stomach;
    GameObject oryugen;
    GameObject strong_addaddaddugen;
    GameObject middle_addaddaddugen;
    GameObject DownKick;
    GameObject SitRightpunch;
    GameObject SitLeftPunch;
    GameObject LeftKick;
    GameObject LeftPunch;
    GameObject SitRightKick;
    GameObject LeftUpperCut;
    GameObject RightKneeKick;
    GameObject RightPunch;
    GameObject SitLeftKick;


    GameObject Idle_Jump_HitBox;
    GameObject SitDown_HitBox;
    
    GameObject Adogen;

    [SerializeField]
    public float Speed;
    public float JumpPower;

    bool isIdle;
    bool isJump;
    bool isSitDown;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        IdleAction();
        JumpAction();
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
            }
        }
    }
    void JumpAction()
    {

    }
    void SitDownAction()
    {

    }

    IEnumerator CreateAdogen()
    {
        yield return new WaitForSeconds(0.7f);
        Instantiate(Adogen, new Vector3(rigid.position.x + 1.7f, rigid.position.y + 0.77f, 0), Quaternion.identity);
    }
}