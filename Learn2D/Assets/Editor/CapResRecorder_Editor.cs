using UnityEngine;
using System.Collections;
using UnityEditor;

public class CapResRecorder_Editor : MonoBehaviour {

	//[MenuItem("GameObject/Create CapResRecorder", false,10)]

	private static void CreateHiResRecorder(MenuCommand menuCommand) {
		
		CapResRecorder recorder = Object.FindObjectOfType<CapResRecorder>();
		if (recorder) {
			Debug.LogWarning("An instance of CapResRecorder already exists!");
			Selection.activeObject = recorder.gameObject;
		} else {
			
			GameObject go = new GameObject("CapResRecorder");
			go.AddComponent<CapResRecorder>();
			GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
			Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
			Selection.activeObject = go;
			
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
