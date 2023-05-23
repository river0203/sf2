using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Adogen : MonoBehaviour
{
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator anim;

    private bool isObjectActive = true;
    public float Speed;
    float blinkInterval = 0.1f;
    private float timer = 0f;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        rigid.velocity = new Vector2(Speed, 0);
        Blink();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            StartCoroutine("DestroyAdogen");
        }
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
    }

    IEnumerator DestroyAdogen()
    {
        anim.Play("AAA");
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
    }
}
