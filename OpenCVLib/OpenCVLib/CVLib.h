#pragma once

#define UNITY_API __stdcall
#define UNITY_EXPORT __declspec(dllexport)

#include <iostream>
#include <opencv2/opencv.hpp>

namespace CVLib {
	extern "C" {
		UNITY_EXPORT void UNITY_API VideoCapInit(int id);
		UNITY_EXPORT unsigned char* UNITY_API ProcessFrame();
		UNITY_EXPORT void UNITY_API freeMemory();
	}
}