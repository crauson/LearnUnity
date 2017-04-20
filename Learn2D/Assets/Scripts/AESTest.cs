using UnityEngine;
using System.Collections;
using System.Text;
using System;
using System.IO;
//using CrausonUtility;

public class AESTest : MonoBehaviour
{
	public string mFilePath;
	public string mShowInfo = "default";
	private const string mEncryptKey = CrausonUtility.AESUtil.gDefaultKey;
	int  decryptSize = 10000;
	// Use this for initialization
	void Start ()
	{
		mFilePath = Application.dataPath+@"/Resources/AESTest.txt";
	}
	void OnGUI()
	{
		GUI.Label(new Rect(50, 200, 200, 50), mShowInfo);
		GUI.color = Color.blue;
		if (GUI.Button(new Rect(50, 250, 200, 30), "保存加密文件"))
		{
			mShowInfo = "保存加密文件！";
			AESSaveFile();
		}
		GUI.color = Color.red;

		if (GUI.Button(new Rect(50, 300, 200, 30), "显示解密文件"))
		{
			ShowAESFile();
			mShowInfo = "显示解密文件！" + mShowInfo;
		}
		GUI.color = Color.cyan;
		if (GUI.Button(new Rect(50, 400, 200, 30), "测试字符串加密"))
		{
			testStrAES();
		}
	}
	void testStrAES()
	{
		string oriStr = "这是个测试加密的字符串:aaaa\nbbb";

		string resultStr = CrausonUtility.AESUtil.AESEncrypt(oriStr, mEncryptKey);
		print ("resultStr"+ resultStr);
		oriStr = CrausonUtility.AESUtil.AESDecrypt(resultStr, mEncryptKey);
		print ("oriStr:"+oriStr);
	}
	void AESSaveFile()
	{
		byte[] texts = new byte[] { };
		try
		{
			string testStr = "这是个测试加密的字符串:aaaa\nbbb";
			//加密
			texts = CrausonUtility.AESUtil.AESEncrypt(Encoding.UTF8.GetBytes(testStr), mEncryptKey);
		}
		catch (Exception e)
		{
			Debug.LogError("Message:" + e.Message);
		}
		if (File.Exists(mFilePath))
		{
			File.Delete(mFilePath);
		}
		using (FileStream fs = new FileStream(mFilePath, FileMode.OpenOrCreate, FileAccess.Write))
		{
			if (fs != null)
			{
				fs.Write(texts, 0, texts.Length);
				fs.Flush();
				fs.Dispose();
			}
		}
	}
	void ShowAESFile()
	{
		try
		{
			string DecrypText = string.Empty;
			using (FileStream fs = new FileStream(mFilePath, FileMode.Open, FileAccess.Read))
			{
				if (fs.Length > 0)
				{
					int blockCount = ((int)fs.Length - 1) / decryptSize + 1;
					for (int i = 0; i < blockCount; i++)
					{
						int size = decryptSize;
						if (i == blockCount - 1) size = (int)(fs.Length - i * decryptSize);
						byte[] bArr = new byte[size];
						fs.Read(bArr, 0, size);
						//解密
						byte[] result = CrausonUtility.AESUtil.AESDecrypt(bArr, mEncryptKey);
						DecrypText += Encoding.UTF8.GetString(result);
					}
					fs.Close();
					fs.Dispose();
				}
			}
			mShowInfo = DecrypText;
		}
		catch (Exception e)
		{
			Debug.LogError("Message:" + e.Message);
		}
	}

	// Update is called once per frame
	void Update ()
	{
	
	}
}

