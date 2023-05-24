using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Health playerHealth;
    public float kickDamage = 20f; // 킥 데미지
    public float punchDamage = 10f; // 펀치 데미지

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyAttack")) // 충돌한 객체의 태그가 "EnemyAttack"인 경우
        {
            if (other.CompareTag("Kick")) // 충돌한 객체의 태그가 "Kick"인 경우
            {
                playerHealth.TakeDamage(kickDamage);
            }
            else if (other.CompareTag("Punch")) // 충돌한 객체의 태그가 "Punch"인 경우
            {
                playerHealth.TakeDamage(punchDamage);
            }
        }
    }
}

public class Health : MonoBehaviour
{
    public float maxHealth = 100f; // 최대 체력
    public float currentHealth = 100f; // 현재 체력
    public Image hpBarImage; // HP 바의 이미지

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount; // 데미지만큼 체력 감소
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth); // HP의 값이 0보단 크고 100보단 작게 설정

        UpdateHPBar(); // HP 바 업데이트

        if (currentHealth <= 0f)
        {
            currentHealth = 0f;
            Die(); // 체력이 0 이하로 내려갔을 때 사망 처리
        }
    }

    private void Die()
    {
        Debug.Log("플레이어가 사망했습니다.");
        // 플레이어가 사망했을 때 처리할 코드 작성
        // 예를 들어, 게임 오브젝트를 비활성화하거나 게임 오버 화면을 표시하는 등의 동작 수행
    }

    private void UpdateHPBar()
    {
        float fillAmount = currentHealth / maxHealth; // fillAmount 계산
        hpBarImage.fillAmount = fillAmount; // HP 바 이미지의 fillAmount 업데이트
    }
}
