using System;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns {

	// public abstract class SingletonStateMachine<T> : Singleton<SingletonStateMachine<T>> where T : StateMachine<T> {
	//
	// 	private State<T> state;
	// 	protected int commandsCountFixed;
	// 	[SerializeField]
	// 	protected bool executeCommandsInFixed;
	// 	public Queue<Command<T>> commandsQueue;
	//
	//
	// 	protected override void Awake() {
	// 		base.Awake();
	// 		commandsQueue = new Queue<Command<T>>();
	// 		if (typeof(T) != GetType()) {
	// 			throw new Exception("State instance and StateMachine type mismatch!");
	// 		}
	// 	}
	//
	// 	protected virtual void Update() {
	// 		state?.Update();
	// 		state?.HandleInput();
	// 		if ( !executeCommandsInFixed) {
	// 			while (commandsQueue.Count > 0) {
	// 				commandsQueue.Dequeue().Execute();
	// 			}
	// 		}
	// 	}
	//
	// 	protected virtual void FixedUpdate() {
	// 		if (executeCommandsInFixed) {
	// 			commandsCountFixed = commandsQueue.Count;
	// 			while (commandsQueue.Count > 0) {
	// 				commandsQueue.Dequeue().Execute();
	// 			}
	// 		}
	// 	}
	// }

}