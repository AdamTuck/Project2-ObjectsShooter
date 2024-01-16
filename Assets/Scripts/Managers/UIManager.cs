using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("Gameplay")]
    [SerializeField] private TMP_Text txtHealth;
    [SerializeField] private TMP_Text txtScore;
    [SerializeField] private TMP_Text txtHighScore;
    [SerializeField] private TMP_Text txtLevel;
    [SerializeField] private GameObject txtLevelObj;
    [SerializeField] private float levelTextTimeout;
    [SerializeField] private TMP_Text txtNuke;

    [Header("Menu")]
    [SerializeField] private GameObject menuCanvas;
    [SerializeField] private GameObject lblGameOver;
    [SerializeField] private TMP_Text txtMenuHighScore;
    [SerializeField] private GameObject fireworksObj;

    [Header("Pause")]
    [SerializeField] private GameObject pauseCanvas;

    private Player player;
    private ScoreManager scoreManager;

    private float levelTextTimer;
    private bool levelTextShowing;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameManager.GetInstance().scoreManager;

        GameManager.GetInstance().OnGameStart += GameStarted;
        GameManager.GetInstance().OnGameOver += GameOver;
    }

    void Update()
    {
        LevelTextTimeout();
    }

    public void UpdateHealth(float currentHealth)
    {
        float roundedHealth = Mathf.Floor(currentHealth);
        txtHealth.SetText(roundedHealth.ToString());
    }

    public void UpdateScore()
    {
        txtScore.SetText(scoreManager.GetScore().ToString());
    }

    public void UpdateHighScore ()
    {
        txtHighScore.SetText(scoreManager.GetHighScore().ToString());
        txtMenuHighScore.SetText($"High Score: {scoreManager.GetHighScore().ToString()}");
    }

    public void GameStarted ()
    {
        player = GameManager.GetInstance().GetPlayer();
        player.health.OnHealthUpdate += UpdateHealth;

        lblGameOver.SetActive(false);
        menuCanvas.SetActive(false);
        fireworksObj.SetActive(false);

        ShowLevel(1);
    }

    public void ShowPauseScreen()
    {
        pauseCanvas.SetActive(true);
    }

    public void HidePauseScreen()
    {
        pauseCanvas.SetActive(false);
    }

    public void GameOver()
    {
        lblGameOver.SetActive(true);
        menuCanvas.SetActive(true);
        fireworksObj.SetActive(true);
    }

    public void ShowLevel(int currentLevel)
    {
        txtLevel.SetText("LEVEL " + currentLevel);
        txtLevelObj.SetActive(true);
        levelTextShowing = true;
    }

    public void UpdateNukeText (float nukeAmount)
    {
        txtNuke.SetText (nukeAmount.ToString());
    }

    private void LevelTextTimeout()
    {
        if (levelTextShowing)
        {
            levelTextTimer += Time.deltaTime;

            if (levelTextTimer > levelTextTimeout)
            {
                levelTextShowing = false;
                levelTextTimer = 0;

                txtLevelObj.SetActive(false);
            }
        }
    }
}
