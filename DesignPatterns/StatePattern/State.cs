namespace DesignPatterns {
public abstract class State<T> where T : StateMachine<T> {

	protected T machine;

	protected State(T machine) {
		this.machine = machine;
	}

	public abstract void HandleInput();

	public abstract void Update();

}
}