using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombeCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            GameManager.instance.health -= 1;
            Destroy(gameObject);
        }
    }
}
