using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Transform Player;
    void Update()
    {
        transform.position = new Vector3(Player.position.x, Player.position.y, -10);
    }
}
