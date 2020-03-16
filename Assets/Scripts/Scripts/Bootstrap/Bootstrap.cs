using UnityEngine;
using UnityEngine.SceneManagement;

public class Bootstrap
{

    [RuntimeInitializeOnLoadMethod]
    private static void OnRuntimeLoad()
    {
        if (SceneManager.GetActiveScene().name != "Bootstrap")
        {
            SceneManager.LoadScene("Bootstrap", LoadSceneMode.Additive);

        }
    }
}