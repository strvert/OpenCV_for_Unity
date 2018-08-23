#pragma once
#include <opencv2/opencv.hpp>

class VideoCapture {
public:
	VideoCapture(int);
	~VideoCapture();
	unsigned char* Read();
	cv::Mat _ReadCV();
	bool isOpened();
private:
	unsigned char* result;
	cv::VideoCapture* cap;
};