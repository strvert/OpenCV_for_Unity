using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CVLib{
public class OpenCVTest : MonoBehaviour
{
    private Texture2D tex1;
    private Texture2D tex2;
    private bool loop;
    public int id;
    // Use this for initialization
    void Start () {
        OpenCVLib.VideoCapInit(id);
        loop = true;
    }
    
    // Update is called once per frame
    void Update () {
        // これもうちょっとどうにかならないのか
        byte[] imgData = OpenCVLib.ProcessFrame();
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
        OpenCVLib.freeMemory();
    }
}
}
