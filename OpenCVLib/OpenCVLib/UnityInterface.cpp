#include "UnityInterface.h"

VideoCapture* com_strv_VideoCapture_Create(int id) {
	return new VideoCapture(id);
}

void com_strv_VideoCapture_Destroy(VideoCapture* instance) {
	if (instance == nullptr) {
		return;
	}

	delete instance;
	instance = nullptr;
}

unsigned char* com_strv_VideoCapture_Read(VideoCapture* instance) {
	if (instance == nullptr) {
		return 0;
	}
	return instance->Read();
}

bool com_strv_VideoCapture_isOpened(VideoCapture* instance) {
	if (instance == nullptr) {
		return false;
	}
	return instance->isOpened();
}
