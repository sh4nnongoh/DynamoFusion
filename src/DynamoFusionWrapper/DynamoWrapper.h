// DynamoWrapper.h
#pragma once

//class DynamoWrapperPrivate;

// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the DESIGNSCRIPTRUNNER_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// DESIGNSCRIPTRUNNER_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef DYNAMO_EXPORTS
#define DYNAMO_API __declspec(dllexport)
#else
#define DYNAMO_API __declspec(dllimport)
#endif

class DYNAMO_API DynamoWrapper
{

//public: DynamoWrapper();

//public: ~DynamoWrapper();

public: static void LoadDynamo();

};

