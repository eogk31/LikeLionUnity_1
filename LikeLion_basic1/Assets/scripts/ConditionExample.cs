using UnityEngine;

public class ConditionExample : MonoBehaviour
{
    public int health = 100;

    void Update()
    {
        // ü�� ���� ������
        health = -1;
        Debug.Log($"healh: {health}");

        // ü�� �������ǹ�
        if (health <= 0)
        {
            Debug.Log("Game Over...");
        }
    }
}
