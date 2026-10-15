using UnityEngine;

public class GameManager : MonoBehaviour
{
  // the one everyone uses:
  public static GameManager Instance;

  // survives scene loads:
  public int score;
  public bool playerWon;

  void Awake()
  {
    if (Instance != null) {
      Destroy(gameObject); return;
    }
    Instance = this;
    DontDestroyOnLoad(gameObject);
  }
}
