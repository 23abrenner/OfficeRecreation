// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class MMC_Off_RecreationTarget : TargetRules
{
	public MMC_Off_RecreationTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "MMC_Off_Recreation" } );
	}
}
