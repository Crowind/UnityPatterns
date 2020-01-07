using System;
using System.Collections.Generic;

namespace DesignPatterns {

	public abstract class SingletonStateMachine<T> : Singleton<SingletonStateMachine<T>> where T : StateMachine<T> {

		private State<T> state;
		public Queue<Command<T>> commandsQueue;
		public State<T> State {
			get => state;
			set => state = value;
		}

		protected override void Awake() {
			base.Awake();
			commandsQueue = new Queue<Command<T>>();
			if (typeof(T) != GetType()) {
				throw new Exception("State instance and StateMachine type mismatch!");
			}
		}

		protected virtual void Update() {

			State?.Update();
			State?.HandleInput();
			if (commandsQueue.Count > 0) {
				commandsQueue.Dequeue().Execute();
			}

		}
	}

}