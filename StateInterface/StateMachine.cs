using System;
using UnityEngine;

public abstract class StateMachine<T> : MonoBehaviour where T : StateMachine<T> {

	private State<T> state;
	public State<T> State {
		get => state;
		set => state = value;
	}
	public virtual void Awake() {
		if (typeof(T) != GetType()) {
			Destroy(gameObject);
			throw new Exception("State instance and StateMachine type mismatch!");
		}
	}
	public virtual void Update() {
		State?.Update();
		State?.HandleInput();
	}
}