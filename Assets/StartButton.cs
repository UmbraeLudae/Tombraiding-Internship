using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void OnPress()
    {
        SceneManager.LoadScene(1);
    }
}
