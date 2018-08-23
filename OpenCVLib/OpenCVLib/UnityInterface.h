#pragma once
#define UNITY_API __stdcall
#define UNITY_EXPORT __declspec(dllexport)

#include "VideoCapture.h"

extern "C" {
	UNITY_EXPORT VideoCapture* UNITY_API com_strv_VideoCapture_Create(int);
	UNITY_EXPORT void UNITY_API com_strv_VideoCapture_Destroy(VideoCapture*);
	UNITY_EXPORT unsigned char* UNITY_API com_strv_VideoCapture_Read(VideoCapture*);
	UNITY_EXPORT bool UNITY_API com_strv_VideoCapture_isOpened(VideoCapture*);
}