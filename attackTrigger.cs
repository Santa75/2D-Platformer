using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackTrigger : MonoBehaviour
{
	public int dmg = 60;
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.isTrigger != true && col.CompareTag("Damage"))
		{
			col.SendMessageUpwards("Damage", dmg);
		}

	}
}
