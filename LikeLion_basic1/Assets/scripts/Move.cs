using UnityEngine;

public class Move : MonoBehaviour
{
    // �̵� �ӵ�
    public float speed = 5.0f;
    void Update()
    {
        // Ű �Է¿� ���� �̵�
        float move = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * move * speed *Time.deltaTime);
        
    }
}
