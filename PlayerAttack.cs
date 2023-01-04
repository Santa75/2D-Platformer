using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

	private bool attacking = false;
	private float attackTimer = 0;
	private float attackCd = 1f;
	public Collider2D attackTrigger;
	private Animator anim;


	void Awake()
	{
		anim = gameObject.GetComponent<Animator>();
		attackTrigger.enabled = false;

	}


	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.X) && !attacking)
		{
			attacking = true;
			attackTimer = attackCd;
			attackTrigger.enabled = true;
			Debug.Log("attack");

		}

		if (attacking)
		{
			if (attackTimer > 0)
			{
				attackTimer -= Time.deltaTime;
			}
			else
			{
				attacking = false;
				attackTrigger.enabled = false;
			}
		}

		anim.SetBool("Attacking", attacking);

	}
}
