using UnityEngine;

public class CeilingFan : MonoBehaviour
{
    public float rotationSpeed = 100f;

    public bool isSpinning = true;

    void Update()
    {
        if (isSpinning)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }

    public void ToggleSpin()
    {
        isSpinning = !isSpinning;
    }
}
