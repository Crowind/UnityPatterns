using System;

namespace DesignPatterns {

	public class Example : StateMachine<Example> {

		protected override void Awake() {
			base.Awake();
			var idle = new ExampleState(this);
			possibleStates.Add(idle.GetType(),idle);
			state = idle;
		}
	}

	public class ExampleState : State<Example> {

		public ExampleState(Example machine) : base(machine) { }

		public override void HandleInput() {
			machine.ChangeState( typeof(ExampleState));
		}
		public override void Update() {
			throw new System.NotImplementedException();
		}
		public override void Init() {
			throw new NotImplementedException();
		}

	}

	public class ExampleCommand : Command<Example> {
		public ExampleCommand(Example subject) : base(subject) { }

		public override void Execute() {
			throw new System.NotImplementedException();
		}
	}

}