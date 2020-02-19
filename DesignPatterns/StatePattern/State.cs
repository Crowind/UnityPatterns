namespace DesignPatterns {

	public abstract class State<T> where T : StateMachine<T> {

		// ReSharper disable once MemberCanBePrivate.Global
		// ReSharper disable once NotAccessedField.Global
		protected T machine;

		protected State(T machine) {
			this.machine = machine;
		}

		public abstract void HandleInput();

		public abstract void Update();

		public void Init(inputData<State<T>> data) { }

		public class inputData<U> where U:State<T> {
			
		}
	}

}