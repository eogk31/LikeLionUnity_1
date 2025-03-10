using UnityEngine;

public class Move : MonoBehaviour
{
    // 이동 속도
    public float speed = 5.0f;
    void Update()
    {
        // 키 입력에 따른 이동
        float move = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * move * speed *Time.deltaTime);
        
    }
}
