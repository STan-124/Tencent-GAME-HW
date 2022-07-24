// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MyFPS4mobile : ModuleRules
{
	public MyFPS4mobile(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
