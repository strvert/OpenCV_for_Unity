#include <iostream>
#include <opencv2/opencv.hpp>
#include "VideoCapture.h"

int main() {
	VideoCapture* cap = new VideoCapture(0);
	while (1) {
		cv::imshow("showWindow", cap->_ReadCV());
		int key = cv::waitKey(1);
		if (key == 113) break;
	}
	cv::destroyAllWindows();
	delete cap;
	return 0;
}