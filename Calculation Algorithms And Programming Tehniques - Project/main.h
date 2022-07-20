#pragma once
#include "project.h"
#include "utils.h"

// MAIN CLASS
class mainc {
	public:
		project PROIECT;
		UTIL::utils UTILS;
		mainc() : PROIECT(this), UTILS(this) {}
};


