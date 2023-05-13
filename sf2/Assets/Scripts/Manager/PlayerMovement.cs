using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //좌표를 통한 캐릭터 이동
public class PlayerMovement : MonoBehaviour 
{
    float moveX, moveY;
    [SerializeField]
    float maxSpeed = 5f;
    
    private void Update() 
    {
        moveX = Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;
        moveY = Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);
    }

}