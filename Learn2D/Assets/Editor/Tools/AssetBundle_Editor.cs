using UnityEngine;
using System.Collections;
using UnityEditor;

public class AssetBundle_Editor : MonoBehaviour {
	//[MenuItem("BuildBudle/Build Asset Bundles")]
	static void BuildAssetBundle()
	{
		string str = Application.dataPath + "/AssetBundles";
		//打包资源路径
		BuildPipeline.BuildAssetBundles(str, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
