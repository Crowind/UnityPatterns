
public abstract  class Command<T1> where T1:Actor<T1>{
	private T1 subject;
	
	protected Command(T1 subject) {
		this.subject = subject;
	}

	public abstract void Execute();
}