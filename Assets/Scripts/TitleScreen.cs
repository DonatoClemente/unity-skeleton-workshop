using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class TitleScreen : MonoBehaviour
{
  void Update()
  {
    if (Keyboard.current.spaceKey.wasPressedThisFrame)
    {
        SceneManager.LoadScene("Level");
    }
  }
}
