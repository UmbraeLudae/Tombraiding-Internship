
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public const int PlayerScene = 1;
    private int currentLevelIndex = 1;

    [SerializeField] private Transform player;
    [SerializeField] private PlayerWhip whip;
    [SerializeField] private VelocityController controller;

    private Scene currentLevel;

    public static LevelLoader Instance;

    void Start()
    {
        Instance = this;
        ChangeLevel(1);
    }

    public static void Next()
    {
        Instance.ChangeLevel(++Instance.currentLevelIndex);
    }

    private void ChangeLevel(int level)
    {
        whip.WhipStop();
        DialogueUI.ShowConversation(null);
        if (currentLevel.isLoaded) SceneManager.UnloadSceneAsync(currentLevel);
        if (level <= 0 || level >= SceneManager.sceneCountInBuildSettings - PlayerScene) return; //nothing to load
        var buildIndex = level + PlayerScene;
        var async = SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive);
        async.completed += _ =>
        {
            currentLevel = SceneManager.GetSceneByBuildIndex(buildIndex);
            var spawnPoint = currentLevel.GetRootGameObjects().Where(go => go.name.Contains("SpawnPoint")).First();
            player.transform.position = spawnPoint.transform.position._x0z();
            controller.Clear();
        };
    }
}
