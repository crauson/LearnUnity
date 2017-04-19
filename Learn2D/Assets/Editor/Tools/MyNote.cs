﻿using UnityEngine;
using System.Collections;
using UnityEditor;

public class MyNote : EditorWindow {
	string note = "Notes:\n->\n->";
	[MenuItem("Examples/QuickNotes")]
	static void Init()
	{
		MyNote window = (MyNote)EditorWindow.GetWindow(typeof(MyNote));
		window.Show();
	}
	
	void OnGUI()
	{
		note = EditorGUILayout.TextArea(note,
		                                GUILayout.Width(position.width - 5),
		                                GUILayout.Height(position.height - 30));
		EditorGUILayout.BeginHorizontal();
		if (GUILayout.Button("Reset"))
			note = "";
		if (GUILayout.Button("Clear Story", GUILayout.Width(72)))
		{
			note = "Notes:\n->\n->";
		}
		EditorGUILayout.EndHorizontal();
	}
	
	void OnFocus()
	{
		if (EditorPrefs.HasKey("QuickNotes"))
			note = EditorPrefs.GetString("QuickNotes");
	}
	
	void OnLostFocus()
	{
		EditorPrefs.SetString("QuickNotes", note);
	}
	
	void OnDestroy()
	{
		EditorPrefs.SetString("QuickNotes", note);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
