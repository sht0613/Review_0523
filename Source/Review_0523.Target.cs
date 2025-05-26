// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Review_0523Target : TargetRules
{
	public Review_0523Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		
        DefaultBuildSettings = BuildSettingsVersion.Latest;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;

        ExtraModuleNames.AddRange( new string[] { "Review_0523" } );
	}
}
