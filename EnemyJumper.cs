using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumper : MonoBehaviour {

    public float forceY = 300f;
    private Rigidbody2D myRigidbody;
    private Animator myAnimator;
    private int curHealth = 60;


    void Awake(){
        myRigidbody = GetComponent<Rigidbody2D> ();
        myAnimator = GetComponent<Animator>();
    }
    // Use this for initialization
    void Start () 
    {
        StartCoroutine (Attack());
        curHealth = curHealth;
    }

    IEnumerator Attack(){
        yield return new WaitForSeconds(Random.Range(2, 4));
        forceY = Random.Range(250, 550);
        myRigidbody.AddForce(new Vector2(0, forceY));
        myAnimator.SetBool ("attack", true);
        yield return new WaitForSeconds (1.5f);
        myAnimator.SetBool("attack", false);
        StartCoroutine (Attack());
    }


    void OnTriggerEnter2D(Collider2D target){
    
        if (target.tag == "bullet") {
            Destroy (gameObject);
            Destroy (target.gameObject);
        }
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
