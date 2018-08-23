#include "CVLib.h"

namespace CVLib {
	cv::VideoCapture *cap;
	unsigned char* result;

	void VideoCapInit(int id) {
		cap = new cv::VideoCapture(id);
	}

	unsigned char* ProcessFrame() {
		cv::Mat image;
		cv::Mat betterImage;
		(*cap) >> image;
		cv::flip(image, image, 0);
		cv::cvtColor(image, betterImage, CV_BGR2BGRA, 4);
		result = new unsigned char[image.cols*image.rows*4];
		memcpy(result, betterImage.data, betterImage.cols*image.rows * 4);
		return result;
	}

	void freeMemory() {
		free(result);
	}
}