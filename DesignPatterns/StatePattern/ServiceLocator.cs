
using System;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns {

	public abstract class Entity : MonoBehaviour {
		public readonly Dictionary<Type, EntityComponent> components = new Dictionary<Type, EntityComponent>();
	
		public T Get<T>() where T : EntityComponent {
			return (T)components[typeof(T)];
		}
	}

	public abstract class EntityComponent : MonoBehaviour {
		public abstract void EnableInput();
		public abstract void DisableInput();
		public abstract void SubscribeEvents();
		public abstract void UnsubscribeEvents();
	}

	public abstract class EntityComponent<T> : EntityComponent where T : Entity {
		protected T Entity { get; private set; }

		protected virtual void Awake() {
			Entity = GetComponent<T>();
			Debug.Assert(Entity != null, "No entity found", this);
		}
	}

	public class CharacterController : Entity {
		private void AddComponents() {
			//components.Add(typeof(CharacterMovement), GetComponent<CharacterMovement>());

		}
	}

	public class CharacterDash : EntityComponent<CharacterController> {
		public void OnDash() {
			throw new NotImplementedException();
		}
		public override void EnableInput() {
			throw new NotImplementedException();
		}
		public override void DisableInput() {
			throw new NotImplementedException();
		}
		public override void SubscribeEvents() {
			throw new NotImplementedException();
		}
		public override void UnsubscribeEvents() {
			throw new NotImplementedException();
		}
	}
}
