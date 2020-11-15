// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class ExpressLaneServerTarget : TargetRules
{
	public ExpressLaneServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
        bUsesSteam = true;
		ExtraModuleNames.AddRange( new string[] { "ExpressLane" } );
	}
}
