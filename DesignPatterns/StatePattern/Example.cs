using System;

namespace DesignPatterns {

	public class Example : StateMachine<Example> {

		protected override void Awake() {
			base.Awake();
			var idle = new ExampleState(this);
			possibleStates.Add(idle.GetType(),idle);
			inputDatas.Add(idle.GetType(),new ExampleState.ExampleInitData());
			state = idle;
		}
	}

	public class ExampleState : State<Example> {

		public ExampleState(Example machine) : base(machine) { }

		public override void HandleInput() {
			((ExampleInitData)machine.inputDatas[typeof(ExampleState)]).testValue = 5;
			machine.ChangeState( typeof(ExampleState));
		}
		public override void Update() {
			throw new System.NotImplementedException();
		}
		public new void Init(ExampleInitData initData) {
			throw new NotImplementedException();
		}
		public class ExampleInitData : inputData<State<Example>> {
			public float testValue;
		}
	}

	public class ExampleCommand : Command<Example> {
		public ExampleCommand(Example subject) : base(subject) { }

		public override void Execute() {
			throw new System.NotImplementedException();
		}
	}

}