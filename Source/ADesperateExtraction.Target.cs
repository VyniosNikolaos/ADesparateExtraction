// UniversityVRCourse

using UnrealBuildTool;
using System.Collections.Generic;

public class ADesperateExtractionTarget : TargetRules
{
	public ADesperateExtractionTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V6;

		ExtraModuleNames.AddRange( new string[] { "ADesperateExtraction" } );
	}
}
