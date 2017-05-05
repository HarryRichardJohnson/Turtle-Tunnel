using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{

    public int coinPoints = 1;
    public float rotateSpeed = 50f;

    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * rotateSpeed);
    }

}
