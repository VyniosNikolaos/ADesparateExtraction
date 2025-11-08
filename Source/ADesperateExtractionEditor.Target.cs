// UniversityVRCourse

using UnrealBuildTool;
using System.Collections.Generic;

public class ADesperateExtractionEditorTarget : TargetRules
{
	public ADesperateExtractionEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V6;

		ExtraModuleNames.AddRange( new string[] { "ADesperateExtraction" } );
	}
}
