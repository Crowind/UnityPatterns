using System;
using System.Collections.Generic;

public abstract class Actor<T> where T:Actor<T> {
	
	protected Queue<Command<T> > commandsQueue;
	
	public Actor() {
		if (typeof(T) != GetType()) {
			throw new Exception("Actor type mismatch!");
		}
		commandsQueue = new Queue<Command<T>>();
	}

	public virtual void Update() {
		if (commandsQueue.Count > 0) {
			commandsQueue.Dequeue().Execute();
		}
	}
}

