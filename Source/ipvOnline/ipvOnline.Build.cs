// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ipvOnline : ModuleRules
{
	public ipvOnline(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate",
			"OnlineSubsystem",
			"OnlineSubsystemSteam"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ipvOnline",
			"ipvOnline/Variant_Platforming",
			"ipvOnline/Variant_Platforming/Animation",
			"ipvOnline/Variant_Combat",
			"ipvOnline/Variant_Combat/AI",
			"ipvOnline/Variant_Combat/Animation",
			"ipvOnline/Variant_Combat/Gameplay",
			"ipvOnline/Variant_Combat/Interfaces",
			"ipvOnline/Variant_Combat/UI",
			"ipvOnline/Variant_SideScrolling",
			"ipvOnline/Variant_SideScrolling/AI",
			"ipvOnline/Variant_SideScrolling/Gameplay",
			"ipvOnline/Variant_SideScrolling/Interfaces",
			"ipvOnline/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
