using UnrealBuildTool;

public class BattleChess_GameTarget : TargetRules
{
	public BattleChess_GameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("BattleChess_Game");
	}
}
