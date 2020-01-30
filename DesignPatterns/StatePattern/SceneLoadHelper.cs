using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DesignPatterns {

	public class SceneLoaderHelper : MonoBehaviour {

		public bool showDebugLog;
		public Scene scene;

		public void StartNewScene() {
			StartCoroutine(SceneLoaderTracker(scene));
		}

		private IEnumerator SceneLoaderTracker(Scene scene) {

			if (showDebugLog) {
				Debug.Log("Loaded Scene #" + scene.name);
			}
			AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(scene.handle);
			while (!asyncOperation.isDone) {
				yield return null;
			}
			// Scene loaded ---> Launch Event here
			OnSceneLoaded();
		}

		protected virtual void OnSceneLoaded() { }
	}

}