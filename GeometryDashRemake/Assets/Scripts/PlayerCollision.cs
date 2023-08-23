using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<PlayerBehaviour>().RotationIsEnabled = false;
        if (collision.collider.tag == "Ground")
        {
            GetComponent <PlayerBehaviour>().JumpEnabled = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        GetComponent<PlayerBehaviour>().RotationIsEnabled = true;
    }
}

