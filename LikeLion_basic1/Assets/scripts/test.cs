using UnityEngine;

public class test : MonoBehaviour
{
    // 변수 선언
    public int playerScore = 0;
    public float speed = 5.5f;
    public string playerName = "Hero";
    public bool isGameOver = false;

    void Start() // 시작 시, 1번만 실행
    {
        // 변수 출력
        Debug.Log("Player Name: " + playerName);
        Debug.Log("Player Score: " + playerScore);
        Debug.Log("Speed: " + speed);
        Debug.Log("Is Game Over?: " + isGameOver);

        Debug.Log("Hello, world!");
    }

    void Update() //시작 후, 반복하는 부분(게임이 실행되는 동안)
    {
        print("반복하는 부분");
    }
}
