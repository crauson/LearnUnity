using UnityEngine;
using System.Collections;
using System.IO;

#if UNITY_EDITOR
using UnityEditor;
#endif
public class GenerateFolders_Editor : MonoBehaviour
{
	#if UNITY_EDITOR
	[MenuItem("Tools/CreateBasicFolder #&_b")]
	private  static void CreateBasicFolder()
	{
		GenerateFolder(0);
		Debug.Log("Folders Created");
	}
	
	//[MenuItem("Tools/CreateALLFolder")]
	private static void CreateAllFolder()
	{
		GenerateFolder(1);
		Debug.Log("Folders Created");
	}
	
	
	private static void GenerateFolder(int flag)
	{   
		// 文件路径
		string prjPath = Application.dataPath + "/";

		Directory.CreateDirectory(prjPath + "Resources");
		Directory.CreateDirectory(prjPath + "Scripts");        
		Directory.CreateDirectory(prjPath + "Scenes");
		Directory.CreateDirectory(prjPath + "Standard Assets");
		Directory.CreateDirectory(prjPath + "GUI");

		if (1== flag)
		{
			Directory.CreateDirectory(prjPath + "Textures");
			Directory.CreateDirectory(prjPath + "Audio");
			Directory.CreateDirectory(prjPath + "Prefabs");
			Directory.CreateDirectory(prjPath + "Materials");        
			Directory.CreateDirectory(prjPath + "Meshes");
			Directory.CreateDirectory(prjPath + "Shaders");
		}
		
		AssetDatabase.Refresh();
	}
	
	
	#endif

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
