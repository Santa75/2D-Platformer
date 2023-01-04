using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D target)
    {
        
        if (target.gameObject.tag == "Player")
        {
            Destroy (gameObject);
        }

        if (target.gameObject.tag == "ground")
        {
            Destroy(gameObject);
        }
    }
}
