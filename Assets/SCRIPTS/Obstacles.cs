﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {


	private void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<Hero> () != null) 
		{
			GameControl.instance.HeroScored ();
		}	
	}
	

}
