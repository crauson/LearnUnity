﻿using UnityEngine;
using System.Collections;
using System.Threading;

public class ThreadBehaviour : MonoBehaviour {
	Thread mThread = null;
	int mCount = 0;

    void startThread()
	{
        print("startThread");

        if(mThread == null)
        {
            print("new startThread");

            mThread = new Thread(testThread);
		}
		mThread.Start();
	}
	void stopThread()
	{
		if(mThread != null)
		{
			mThread.Abort();
		}
	}
	void OnGUI()
	{
		if(GUI.Button(new Rect(50, 100, 200, 50), "开启线程"))
		{
			startThread();
		}		
		if(GUI.Button(new Rect(50, 200, 200, 50), "关闭线程"))
		{
			stopThread();
		}

	}
	void testThread()
	{
		print ("Start Thread！");
		while(true)
		{
			print ("Threading:"+mCount);
			mCount ++;
			Thread.Sleep(1000);
		}
	}
	// Use this for initialization
	void Start () {
        print("Start");

        mThread = null;
        mCount = 1;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
