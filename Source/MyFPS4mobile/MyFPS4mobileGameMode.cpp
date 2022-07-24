// Copyright Epic Games, Inc. All Rights Reserved.

#include "MyFPS4mobileGameMode.h"
#include "MyFPS4mobilePawn.h"

AMyFPS4mobileGameMode::AMyFPS4mobileGameMode()
{
	// set default pawn class to our character class
	DefaultPawnClass = AMyFPS4mobilePawn::StaticClass();
}

