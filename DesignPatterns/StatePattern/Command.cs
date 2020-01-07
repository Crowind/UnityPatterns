namespace DesignPatterns {

	public abstract class Command<T> where T : StateMachine<T> {
		private T subject;

		protected Command(T subject) {
			this.subject = subject;
		}

		public abstract void Execute();
	}

}