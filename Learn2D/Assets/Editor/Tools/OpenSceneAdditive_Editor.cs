using UnityEngine;
using System.Collections;
using UnityEditor;

public class OpenSceneAdditive_Editor : Editor {
	//[MenuItem("Examples/Load Scene Additive")]

	static void Apply()
	{
		string strScenePath = AssetDatabase.GetAssetPath(Selection.activeObject);
		if (strScenePath == null || !strScenePath.Contains(".unity"))
		{
			EditorUtility.DisplayDialog("Select Scene","You Must Select a Scene!","OK");
			EditorApplication.Beep();
			return;
		}
		Debug.Log("Opening"+strScenePath+"additively");
		EditorApplication.OpenSceneAdditive(strScenePath);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
