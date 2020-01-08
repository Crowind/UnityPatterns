using System;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns {
	public abstract class StateMachine<T> : MonoBehaviour  where T : StateMachine<T> {

		private State<T> state;
		[SerializeField]
		protected bool executeCommandsInFixed;
		public Queue<Command<T>> commandsQueue;
		public State<T> State {
			get => state;
			set => state = value;
		}

		protected virtual void Awake() {
			commandsQueue = new Queue<Command<T>>();
			if (typeof(T) != GetType()) {
				throw new Exception("State instance and StateMachine type mismatch!");
			}
		}

		protected virtual void Update() {
		
			State?.Update();
			State?.HandleInput();
			if (! executeCommandsInFixed && commandsQueue.Count > 0) {
				commandsQueue.Dequeue().Execute();
			}
		}

		protected void FixedUpdate() {
			if (executeCommandsInFixed && commandsQueue.Count > 0) {
				commandsQueue.Dequeue().Execute();
			}
		}
	}
}