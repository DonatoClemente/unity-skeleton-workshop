using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
  void Update() {            // placeholder game
    var kb = Keyboard.current;
    if (kb.wKey.wasPressedThisFrame) End(true);
    if (kb.lKey.wasPressedThisFrame) End(false);
  }
  void End(bool won) {
    GameManager.Instance.playerWon = won;
    SceneManager.LoadScene("GameOver");
  }
}
