// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"

// When you are using pre-compiled headers, this source file is necessary for compilation to succeed.
extern "C" {

	int __declspec(dllexport) GetNumber() { return 42; }
}