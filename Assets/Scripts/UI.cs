using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public static UI instance;
    [SerializeField] private GameObject GameOverUI;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI killCounterText;
    private int killCount;

    private void Awake()
    {
        instance = this;
        Time.timeScale = 1;
    }

    private void Update()
    {
        timerText.text = Time.timeSinceLevelLoad.ToString("F2") + "s";
    }

    public void EnableGameOverUI()
    {
        Time.timeScale = .2f;
        GameOverUI.SetActive(true);
        Invoke(nameof(StopLevel), 0.5f);
    }

    public void StopLevel()
    {
        Time.timeScale = 0;
    }
    public void RestartLevel()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }

    public void AddKillCount() 
    {
        killCount++;
        killCounterText.text = killCount.ToString();
    }
}
