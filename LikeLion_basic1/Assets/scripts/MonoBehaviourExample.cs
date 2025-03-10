using UnityEngine;

public class MonoBehaviourExample : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Start");
    }
    void Update()
    {
        Debug.Log("Update");
    }

    void FixedUpdate()
    {
        Debug.Log("물리 연산");
    }
}
