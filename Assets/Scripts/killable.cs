﻿using UnityEngine;
using System.Collections;

public class killable : MonoBehaviour {

	public int maxHealth = 200 ;
	public static int currentHealth = 0 ;
	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
	}

	// Update is called once per frame


	public void Hurt (int damage) {

		currentHealth -= damage;
		currentHealth = Mathf.Clamp (currentHealth, 0, maxHealth);

		if (currentHealth <= 0){
			Destroy(gameObject) ;



		}
	}
}
