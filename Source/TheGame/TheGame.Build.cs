// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TheGame : ModuleRules
{
	public TheGame(ReadOnlyTargetRules Target) : base(Target)
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
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"TheGame",
			"TheGame/Variant_Platforming",
			"TheGame/Variant_Platforming/Animation",
			"TheGame/Variant_Combat",
			"TheGame/Variant_Combat/AI",
			"TheGame/Variant_Combat/Animation",
			"TheGame/Variant_Combat/Gameplay",
			"TheGame/Variant_Combat/Interfaces",
			"TheGame/Variant_Combat/UI",
			"TheGame/Variant_SideScrolling",
			"TheGame/Variant_SideScrolling/AI",
			"TheGame/Variant_SideScrolling/Gameplay",
			"TheGame/Variant_SideScrolling/Interfaces",
			"TheGame/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
