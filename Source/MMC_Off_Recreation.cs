// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class MMC_Off_RecreationEditorTarget : TargetRules
{
	public MMC_Off_RecreationEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "MMC_Off_Recreation", "VRBase" } );
	}
}
