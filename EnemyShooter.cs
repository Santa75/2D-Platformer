using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    private int curHealth = 60;

    void Start ()
    {
        StartCoroutine (Attack());
        curHealth = curHealth;
    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds (Random.Range(1, 3));

        Instantiate (bullet, transform.position, Quaternion.identity);
        StartCoroutine (Attack());
    }

    void Update()
    {
        if (curHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Damage(int damage)
    {
        curHealth -= damage;
    }

}
