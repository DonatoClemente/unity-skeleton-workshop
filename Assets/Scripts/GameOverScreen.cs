using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using TMPro;

public class GameOverScreen : MonoBehaviour {
  public TMP_Text resultText;   // drag in

  void Start() {
    bool won = GameManager.Instance.playerWon;
    resultText.text = won ? "You win!" : "You lose!";
  }

  void Update() {
    if (Keyboard.current.rKey.wasPressedThisFrame)
    {
        SceneManager.LoadScene("Title");
    }
  }
}
