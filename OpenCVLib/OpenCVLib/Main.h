#pragma once
#define UNITY_API __stdcall
#define UNITY_EXPORT __declspec(dllexport)

extern "C" {
	UNITY_EXPORT int UNITY_API GetNumber();
	UNITY_EXPORT int UNITY_API SumNumber(int, int);
}