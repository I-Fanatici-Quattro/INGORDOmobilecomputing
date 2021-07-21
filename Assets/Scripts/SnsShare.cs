using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SnsShare : MonoBehaviour
{

	public void Share()
    {
		StartCoroutine(TakeScreenshotAndShare());
    }

	private IEnumerator TakeScreenshotAndShare()
	{
		yield return new WaitForEndOfFrame();

		Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
		ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
		ss.Apply();

		string filePath = System.IO.Path.Combine(Application.temporaryCachePath, "share.png");
		System.IO.File.WriteAllBytes(filePath, ss.EncodeToPNG());

		Destroy(ss);

		new NativeShare().AddFile(filePath)
			.SetSubject("").SetText("").SetUrl("")
			.SetCallback((result, shareTarget) => Debug.Log("Share result: " + result + ", selected app: " + shareTarget))
			.Share();
	}

	}
