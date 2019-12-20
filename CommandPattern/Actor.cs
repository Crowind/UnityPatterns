using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class Actor<T> : MonoBehaviour where T:Actor<T> {
	private Queue<Command<T> > commandsQ;
	
	public virtual void Awake() {
		if (typeof(T) != GetType()) {
			Destroy(gameObject);
			throw new Exception("Actor type mismatch!");
		}
	}
}
