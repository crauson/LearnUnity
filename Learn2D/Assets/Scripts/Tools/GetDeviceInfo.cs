using UnityEngine;
using System.Collections;

public class GetDeviceInfo : MonoBehaviour
{

	void OnGUI ()
	{
		GUILayout.Space (10);
		GUILayout.Label ("设备的详细信息");
		GUILayout.Space (8);
		GUILayout.Label ("设备模型:" + SystemInfo.deviceModel);
		GUILayout.Space (8);
		GUILayout.Label ("设备名称:" + SystemInfo.deviceName);
		GUILayout.Space (8);
		GUILayout.Label ("设备类型:" + SystemInfo.deviceType.ToString ());
		GUILayout.Space (8);
		GUILayout.Label ("设备唯一标识符:" + SystemInfo.deviceUniqueIdentifier);
		GUILayout.Space (8);
		// GUILayout.Label ("是否支持纹理复制:" + SystemInfo.copyTextureSupport.ToString ());
		GUILayout.Label ("显卡ID:" + SystemInfo.graphicsDeviceID.ToString ());
		GUILayout.Label ("显卡名称:" + SystemInfo.graphicsDeviceName);
		GUILayout.Label ("显卡类型:" + SystemInfo.graphicsDeviceType.ToString ());
		GUILayout.Label ("显卡供应商:" + SystemInfo.graphicsDeviceVendor);
		GUILayout.Label ("显卡供应商ID:" + SystemInfo.graphicsDeviceVendorID.ToString ());
		GUILayout.Label ("显卡版本号:" + SystemInfo.graphicsDeviceVersion);
	}
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
