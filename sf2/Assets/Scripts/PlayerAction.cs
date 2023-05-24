// using System.Collections;
// using System.Collections.Generic;
// using UnityEditor;
// using UnityEngine;
// using UnityEngine.Scripting.APIUpdating;

// public class PlayerAction : MonoBehaviour
// {
//     Rigidbody2D rigid;

//     [SerializeField]
//     GameObject[] AttackHitBox;
//     GameObject Idle_Jump_HitBox;
//     GameObject SitDown_HitBox;
//     GameObject Adogen;

//     [SerializeField]
//     public float Speed;
//     public float JumpPower;

//     bool isIdle;
//     bool isJump;
//     bool isSitDown;
//     void Start()
//     {
//         rigid = GetComponent<Rigidbody2D>();
//     }

//     void Update()
//     {
//         IdleAction();
//         JumpAction();
//         SitDownAction();
//     }
//      void IdleAction()
//      {
//          Command.Skill_set = PlayerControll.status.weak_oryugen;
//      }
//      void JumpAction()
//      {

//      }
//      void SitDownAction()
//      {

//      }
//      IEnumerator CreateAdogen()
//      {
//          yield return new WaitForSeconds(0.7f);
//          Instantiate(Adogen, new Vector3(rigid.position.x + 1.7f, rigid.position.y + 0.77f, 0), Quaternion.identity);
//      }
//  }