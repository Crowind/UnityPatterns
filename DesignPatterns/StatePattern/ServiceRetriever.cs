// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertToAutoPropertyWithPrivateSetter
// ReSharper disable ArrangeAccessorOwnerBody

namespace DesignPatterns {
	public abstract class ServiceRetriever<T> : UnityEngine.MonoBehaviour where T : UnityEngine.Object {
		private static T provider;
		protected static T Provider {
			get => provider;
		}
		protected virtual void Awake() {
			provider = FindObjectOfType<T>();
		}
	}
}