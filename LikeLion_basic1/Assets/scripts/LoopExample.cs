using UnityEngine;

public class LoopExample : MonoBehaviour
{
    void Start()
    {
        // while��: ������ ���� �� ����
        int count = 0;
        while(count < 5)
        {
            Debug.Log($"While Count: {count}");
            count++;
        }
    }
}
