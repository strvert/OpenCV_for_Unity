using System;
using System.Runtime.InteropServices;
using UnityScript.Steps;

namespace CVLib{
public static class OpenCVLib
{
    [DllImport("OpenCVLib")]
    public static extern void VideoCapInit(int id);
    [DllImport("OpenCVLib")]
    public static extern byte[] ProcessFrame();
    [DllImport("OpenCVLib")]
    public static extern void freeMemory();
}

public class VideoCapture
{
    [DllImport("OpenCVLib", EntryPoint = "com_strv_VideoCapture_Create")]
    private static extern IntPtr _Create(int id);
    [DllImport("OpenCVLib", EntryPoint = "com_strv_VideoCapture_Destroy")]
    private static extern void _Destroy(IntPtr instance);
    [DllImport("OpenCVLib", EntryPoint = "com_strv_VideoCapture_Read")]
    private static extern byte[] _Read(IntPtr instance);
    [DllImport("OpenCVLib", EntryPoint = "com_strv_VideoCapture_isOpened")]
    private static extern bool _isOpened(IntPtr instance);

    private IntPtr _instance;

    public VideoCapture(int id)
    {
        _instance = _Create(id);
    }

    private bool IsDestroyed()
    {
        return _instance == IntPtr.Zero;
    }

    ~VideoCapture()
    {
        if (IsDestroyed())
        {
            return;
        }

        _Destroy(_instance);
        _instance = IntPtr.Zero;
    }

    public byte[] Read()
    {
        if (IsDestroyed())
        {
            return null;
        }

        return _Read(_instance);
    }

    public bool isOpened()
    {
        return _isOpened(_instance);
    }
}
}
