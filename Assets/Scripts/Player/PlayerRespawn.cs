using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    private void Update()
    {
        // RESTART
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(1);
    }
}
