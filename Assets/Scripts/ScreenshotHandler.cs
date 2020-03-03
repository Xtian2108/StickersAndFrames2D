using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenshotHandler : MonoBehaviour
{

    public Camera camera1;
    public Camera camera2;
    public RenderTexture rt;
    public int resWidth = 1280;
    public int resHeight = 720;

    public bool takeHiResShotFrame = false;
    public bool takeHiResShotSticker = false;
    public RenderTexture fotoconframe;
    public RenderTexture fotoconstickers;
    public string nombreDeFoto;

    public static string ScreenShotName(int width, int height)
    {
        return string.Format("{0}/screenshots/screen_{1}x{2}_{3}.png",
                             Application.dataPath,
                             width, height,
                             System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
    }

    public void TakeHiResShotFrame()
    {
        takeHiResShotFrame = true;
    }

    public void TakeHiResShotStickers()
    {
        takeHiResShotSticker = true;
    }


    void Update()
    {
        takeHiResShotFrame |= Input.GetKeyDown("k");
        if (takeHiResShotFrame)
        {
            rt = new RenderTexture(resWidth, resHeight, 24);
            camera1.targetTexture = rt;
            Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
            camera1.Render();
            RenderTexture.active = rt;
            screenShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
            camera1.targetTexture = null;
            RenderTexture.active = null; // JC: added to avoid errors
            Destroy(rt);
            //byte[] bytes = screenShot.EncodeToPNG();
            //string filename = ScreenShotName(resWidth, resHeight);
            //nombreDeFoto = filename;
            //System.IO.File.WriteAllBytes(filename, bytes);
            //Debug.Log(string.Format("Took screenshot to: {0}", filename));
            takeHiResShotFrame = false;
            fotoconframe = rt;
        }

        if (takeHiResShotSticker)
        {
            rt = new RenderTexture(resWidth, resHeight, 24);
            camera2.targetTexture = rt;
            Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
            camera2.Render();
            RenderTexture.active = rt;
            screenShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
            camera2.targetTexture = null;
            RenderTexture.active = null; // JC: added to avoid errors
            Destroy(rt);
            byte[] bytes = screenShot.EncodeToPNG();
            string filename = ScreenShotName(resWidth, resHeight);
            nombreDeFoto = filename;
            System.IO.File.WriteAllBytes(filename, bytes);
            Debug.Log(string.Format("Took screenshot to: {0}", filename));
            takeHiResShotSticker = false;
            fotoconstickers = rt;
        }
    }
}
