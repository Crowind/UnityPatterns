using System;

public abstract class StateMachine<T>  where T : StateMachine<T> {

	private State<T> state;
	
	public State<T> State {
		get => state;
		set => state = value;
	}
	public StateMachine() {
		if (typeof(T) != GetType()) {
			throw new Exception("State instance and StateMachine type mismatch!");
		}
	}
	public virtual void Update() {
		State?.Update();
		State?.HandleInput();
	}
}