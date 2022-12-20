using UnityEditor;
class AndroidBuilder
{
    static void ProductionBuild()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/MainMenu.unity", "Assets/Scenes/CharSelect.unity", "Assets/Scenes/BossRoom.unity", "Assets/Scenes/PostGame.unity", "Assets/Scenes/Startup.unity" };
        //, "Assets/Scenes/BoosRoom/DungeonBossRoom.unity", "Assets/Scenes/BoosRoom/DungeonEntrance.unity", "Assets/Scenes/BoosRoom/DungeonTransition.unity"
        //buildPlayerOptions.locationPathName = "C:/Users/Владимир Садовский/Downloads/builds/OutputApkName.apk";
        buildPlayerOptions.locationPathName = "/builds/OutputApkName.apk";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
