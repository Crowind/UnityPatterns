using System;

namespace DesignPatterns {

	public class Example : StateMachine<Example> {

		public override void Update() {
			base.Update();
			State= new ExampleState(this);
			//do things
		}
	}

	public class ExampleState : State<Example> {

		public ExampleState(Example machine) : base(machine) { }

		public override void HandleInput() {
			throw new System.NotImplementedException();
		}

		public override void Update() {
			throw new System.NotImplementedException();
		}
	}

	public class ExampleCommand : Command<Example> {
		public ExampleCommand(Example subject) : base(subject) { }

		public override void Execute() {
			throw new System.NotImplementedException();
		}
	}

}