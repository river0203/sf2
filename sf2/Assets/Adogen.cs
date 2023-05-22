using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adogen : MonoBehaviour
{
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;

    private bool isObjectActive = true;
    public float Speed;
    public float blinkInterval = 0.5f;
    private float timer = 0f;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        rigid.velocity = new Vector2(Speed, 0);
        Blink();
    }
    void Blink()
    {
        timer += Time.deltaTime;

        if (timer >= blinkInterval)
        {
            timer = 0f;
            isObjectActive = !isObjectActive;
            float targetAlpha = isObjectActive ? 255 : 0;
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, targetAlpha);
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(gameObject);
        }
    }
}
