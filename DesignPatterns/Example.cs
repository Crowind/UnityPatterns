namespace DesignPatterns {

	public class Example : Singleton<Example> {

		private ExampleActor exampleActor;
		private ExampleStateMachine exampleStateMachine;

		public override void Awake() {
			base.Awake();
			exampleActor = new ExampleActor();
			exampleStateMachine = new ExampleStateMachine();
		}

		private void Update() {
			exampleActor.Update();
			exampleStateMachine.Update();
		}
	}

	public class ExampleStateMachine : StateMachine<ExampleStateMachine> { }

	public class ExampleActor : Actor<ExampleActor> { }

	public class ExampleState : State<ExampleStateMachine> {

		public ExampleState(ExampleStateMachine machine) : base(machine) { }

		public override void HandleInput() {
			throw new System.NotImplementedException();
		}

		public override void Update() {
			throw new System.NotImplementedException();
		}
	}

	public class ExampleCommand : Command<ExampleActor> {
		public ExampleCommand(ExampleActor subject) : base(subject) { }

		public override void Execute() {
			throw new System.NotImplementedException();
		}
	}

}