using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CVLib
{
public class VideoCaptureTest : MonoBehaviour
{
    private VideoCapture cap;
    private byte[] imgData;
    private bool loop;
    private Texture2D tex1, tex2;
    public int id;
    
    // Use this for initialization
    void Start()
    {
        Debug.Log("start");
        cap = new VideoCapture(id);
        loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        imgData = cap.Read();
        if(loop)
        {
            loop = false;
            tex1 = new Texture2D(640, 480, TextureFormat.BGRA32, false);
            tex1.LoadRawTextureData(imgData);
            tex1.Apply(true, true);
            GetComponent<Renderer>().material.mainTexture = tex1;
            Destroy(tex2);
        }
        else
        {
            loop = true;
            tex2 = new Texture2D(640, 480, TextureFormat.BGRA32, false);
            tex2.LoadRawTextureData(imgData);
            tex2.Apply(true, true);
            GetComponent<Renderer>().material.mainTexture = tex2;
            Destroy(tex1);
        }
    }
}
}