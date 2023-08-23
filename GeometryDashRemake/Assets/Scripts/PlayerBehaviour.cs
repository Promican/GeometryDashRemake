using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public Rigidbody2D p;
    public float ForwardSpeed = 5.0f;
    public float Jump = 5.0f;
    public float RotationSpeed = 5.0f;
    public bool RotationIsEnabled = true;
    public bool JumpEnabled = true;

    void FixedUpdate()
    {
        p.velocity = new Vector2(ForwardSpeed, p.velocity.y);

        if (Input.GetKey(KeyCode.Space) && JumpEnabled)
        {
            p.velocity = new Vector2(p.velocity.x, Jump);
            JumpEnabled = false;
        }

        if (RotationIsEnabled)
        {
            transform.Rotate(0, 0, transform.rotation.z - RotationSpeed);
        }
    }
}
