using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{

    public movement move;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
