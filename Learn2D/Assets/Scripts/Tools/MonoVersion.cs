using UnityEngine;
using System.Collections;
using System.Reflection;
using System;

public class MonoVersion : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		Type type = Type.GetType ("Mono.Runtime");
		if (type != null) {
			MethodInfo info = type.GetMethod ("GetDisplayName", BindingFlags.NonPublic | BindingFlags.Static);
			if (info != null) {
				print (info.Invoke (null, null));
			}
		} 
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
