// Copyright (c) Meta Platforms, Inc. and affiliates.All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class GraphicsShowcaseEditorTarget : TargetRules
{
	public GraphicsShowcaseEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_3;

		ExtraModuleNames.AddRange( new string[] { "GraphicsShowcase" } );
	}
}
