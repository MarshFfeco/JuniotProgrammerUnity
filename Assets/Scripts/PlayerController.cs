using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 45.0f;

    private float horizontalInut;
    private float fowardInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInut = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");
        // Move Vehicle to foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        if (fowardInput != 0)
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInut);
    }
}
