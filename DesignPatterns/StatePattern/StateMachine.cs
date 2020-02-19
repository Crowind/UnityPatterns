using System;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

namespace DesignPatterns {

	public abstract class StateMachine<T> : MonoBehaviour where T : StateMachine<T> {

		protected State<T> state;
		protected Dictionary<Type, State<T>> possibleStates;

		protected int commandsCountFixed;
		[SerializeField] protected bool executeCommandsInFixed;
		public Queue<Command<T>> commandsQueue;

		protected virtual void Awake() {
			commandsQueue = new Queue<Command<T>>();
			possibleStates = new Dictionary<Type, State<T>>();

			if (typeof(T) != GetType()) {
				throw new Exception("State instance and StateMachine type mismatch!");
			}
		}

		protected virtual void Update() {
			state?.Update();
			state?.HandleInput();
			if (!executeCommandsInFixed) {
				while (commandsQueue.Count > 0) {
					commandsQueue.Dequeue().Execute();
				}
			}
		}

		protected virtual void FixedUpdate() {
			if (executeCommandsInFixed) {
				commandsCountFixed = commandsQueue.Count;
				while (commandsQueue.Count > 0) {
					commandsQueue.Dequeue().Execute();
				}
			}
		}

		public void ChangeState(Type stateType) {

			possibleStates[stateType].Init();
			state = possibleStates[stateType];
			
		}
	}

}