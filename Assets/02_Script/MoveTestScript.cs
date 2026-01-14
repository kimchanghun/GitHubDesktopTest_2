using UnityEngine;

public class MoveTestScript : MonoBehaviour
{
    public float speed = 5f;          // Movement speed

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontal, 0, vertical) * speed;
        gameObject.transform.position += move;
    }

}

// kim changhun unity project