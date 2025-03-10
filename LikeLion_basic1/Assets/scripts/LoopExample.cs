using UnityEngine;

public class LoopExample : MonoBehaviour
{
    void Start()
    {
        // while문: 조건이 참일 때 실행
        int count = 0;
        while(count < 5)
        {
            Debug.Log($"While Count: {count}");
            count++;
        }
    }
}
