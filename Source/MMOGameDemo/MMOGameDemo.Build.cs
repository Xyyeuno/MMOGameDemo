// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MMOGameDemo : ModuleRules
{
	public MMOGameDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "GameplayAbilities", "GameplayTags", "GameplayTasks" });
	}
}
