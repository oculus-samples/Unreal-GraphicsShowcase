// Copyright (c) Meta Platforms, Inc. and affiliates.All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class GraphicsShowcaseTarget : TargetRules
{
	public GraphicsShowcaseTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_3;

		ExtraModuleNames.AddRange( new string[] { "GraphicsShowcase" } );
	}
}
