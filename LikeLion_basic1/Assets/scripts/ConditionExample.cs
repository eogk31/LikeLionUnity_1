using UnityEngine;

public class ConditionExample : MonoBehaviour
{
    public int health = 100;

    void Update()
    {
        // 체력 감소 연산자
        health = -1;
        Debug.Log($"healh: {health}");

        // 체력 감소조건문
        if (health <= 0)
        {
            Debug.Log("Game Over...");
        }
    }
}
