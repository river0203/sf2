using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerAction : MonoBehaviour
{
    Rigidbody2D rigid;

    [SerializeField]
    GameObject[] AttackHitBox;
    GameObject Idle_Jump_HitBox;
    GameObject SitDown_HitBox;
    GameObject Adogen;

    [SerializeField]
    public float Speed;
    public float JumpPower;

    bool isIdle;
    bool isJump;
    bool isSitDown;
    bool isAction;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        PlayerPositionState();
        Move_Jump_SitDown();
        IdleAction();
        JumpAction();
        SitDownAction();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isJump = false;
        }
    }

    void PlayerPositionState()
    {
        if ((isJump || isSitDown) == false)
        {
            isIdle = true;
            Idle_Jump_HitBox.SetActive(true);
        }
    }
    void Move_Jump_SitDown()
    {
        //ÁÂ¿ì ÀÌµ¿
        if (SystemState.status == "b")
        {
            rigid.velocity = new Vector2(Speed * (-1), 0f);
        }
        else if (SystemState.status == "f")
        {
            rigid.velocity = new Vector2(Speed, 0f);
        }

        //Á¡ÇÁ
        if ((SystemState.status == "u" || SystemState.status == "ub" || SystemState.status == "uf") && isJump == false)
        {
            isJump = true;
            isIdle = false;
            isSitDown = false;
            rigid.AddForce(new Vector2(0f, JumpPower), ForceMode2D.Impulse);

            Idle_Jump_HitBox.SetActive(true);
        }

        //¾É±â
        if (SystemState.status == "d" || SystemState.status == "bd" || SystemState.status == "fd")
        {
            isSitDown = true;
            isIdle = false;
            isJump = false;
            rigid.velocity = new Vector2(0, 0);

            SitDown_HitBox.SetActive(true);
        }
    }

    void IdleAction()
    {
        if (isIdle == true)
        {
            if (SystemState.Key == "A")
            {
                StartCoroutine(Active_HitBox());
            }
            else if (SystemState.status == "adogen")
            {
                StartCoroutine(CreateAdogen());
            }
        }
    }
    void JumpAction()
    {
        if (isJump == true) { }
    }
    void SitDownAction()
    {
        if (isSitDown == true) { }
    }

    IEnumerator Active_HitBox(GameObject HitBox, float WaitTime)
    {
        HitBox.SetActive(true);
        yield return new WaitForSeconds(WaitTime);
        HitBox.SetActive(false);
    }

    IEnumerator CreateAdogen()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(Adogen, new Vector3(rigid.position.x + 1.7f, rigid.position.y + 0.77f, 0), Quaternion.identity);
    }
}
