using UnityEngine;

public class test : MonoBehaviour
{
    // ���� ����
    public int playerScore = 0;
    public float speed = 5.5f;
    public string playerName = "Hero";
    public bool isGameOver = false;

    void Start() // ���� ��, 1���� ����
    {
        // ���� ���
        Debug.Log("Player Name: " + playerName);
        Debug.Log("Player Score: " + playerScore);
        Debug.Log("Speed: " + speed);
        Debug.Log("Is Game Over?: " + isGameOver);

        Debug.Log("Hello, world!");
    }

    void Update() //���� ��, �ݺ��ϴ� �κ�(������ ����Ǵ� ����)
    {
        print("�ݺ��ϴ� �κ�");
    }
}
