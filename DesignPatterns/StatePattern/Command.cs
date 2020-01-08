namespace DesignPatterns {

	public abstract class Command<T> where T : StateMachine<T> {
		protected T subject;

		protected Command(T subject) {
			this.subject = subject;
		}

		public abstract void Execute();
	}

}