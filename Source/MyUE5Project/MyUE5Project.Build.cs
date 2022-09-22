// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MyUE5Project : ModuleRules
{
	public MyUE5Project(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		
		/** Add "FMODStudio" and "PhysicsCore" to be able to use and compile FMOD's API and UPhysicalMaterial in C++ */
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore",
			"HeadMountedDisplay", "FMODStudio", "PhysicsCore"});
	} 
}
