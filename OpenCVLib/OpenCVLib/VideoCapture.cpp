#include "VideoCapture.h"

VideoCapture::VideoCapture(int id) {
	cap = new cv::VideoCapture(id);
}

VideoCapture::~VideoCapture() {
	delete result;
	cap->release();
}

unsigned char* VideoCapture::Read() {
	cv::Mat image;
	cv::Mat betterImage;
	(*cap) >> image;
	cv::flip(image, image, 0);
	cv::cvtColor(image, betterImage, CV_BGR2BGRA, 4);
	result = new unsigned char[image.cols*image.rows*4];
	memcpy(result, betterImage.data, betterImage.cols*image.rows * 4);
	return result;
}

cv::Mat VideoCapture::_ReadCV() {
	cv::Mat image;
	(*cap) >> image;
	return image;
}

bool VideoCapture::isOpened() {
	return cap->isOpened();
}