using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonbonCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            GameManager.instance.points += 100;
            Destroy(gameObject);
        }
    }
}
