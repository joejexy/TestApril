using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI highscoreText;
    [SerializeField] private Button playButton;

    private void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
    }

    private void Start()
    {
        highscoreText.text = PlayerPrefs.GetInt("Highscore").ToString();
    }

    private void OnEnable()
    {
        // Load the high score from PlayerPrefs and display it
        highscoreText.text = PlayerPrefs.GetInt("Highscore").ToString();
    }

    private void OnDestroy()
    {
        playButton.onClick.RemoveListener(OnPlayButtonClicked);
    }

    private void OnPlayButtonClicked()
    {
        // Load the game scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}
