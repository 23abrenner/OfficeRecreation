// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class MMC_Off_Recreation : ModuleRules
{
	public MMC_Off_Recreation(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
        //These include the libraries need by Unreal Engine and VR Headsets
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "Slate", "SlateCore" });
		PrivateDependencyModuleNames.AddRange(new string[] { "HeadMountedDisplay", "SteamVR" });

        //These allow us to reference files in the VRBase directory from anywhere in the project - you may need to add
        //another path for your machine.
		PublicIncludePaths.Add("C:/Users/Public/Documents/Public Projects/MMC_Off_Recreation/Source/MMC_Off_Recreation/VRBase");
        PublicIncludePaths.Add("C:/Users/Public/Documents/Public Projects/MMC_Office_Recreation/Source/MMC_Off_Recreation/VRBase");
        PublicIncludePaths.Add("C:/Users/Public/Public Projects/MMC-Office-Recreation/Source/MMC_Off_Recreation/VRBase");

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}
