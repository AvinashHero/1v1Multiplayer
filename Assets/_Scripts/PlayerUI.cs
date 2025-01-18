using System;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private GameObject crossArrowTurn;
    [SerializeField]
    private GameObject circleArrowTurn;
    [SerializeField]
    private GameObject crossYouText;
    [SerializeField]
    private GameObject circleYouText;

    private void Awake()
    {
        crossArrowTurn.SetActive(false);
        circleArrowTurn.SetActive(false);
        crossYouText.SetActive(false);
        circleYouText.SetActive(false);
    }

    private void Start()
    {
        GameManager.Instance.OnGameStarted += GameManager_OnGameStarted;
        GameManager.Instance.OnCurrentPlayablePlayerChanged += GameManager_OnCurrentPlayablePlayerChanged;
    }
    private void GameManager_OnCurrentPlayablePlayerChanged(object sender, EventArgs e)
    {
        UpdateCurrentArrow();
    }

    private void GameManager_OnGameStarted(object sender, EventArgs e)
    {
        if(GameManager.Instance.GetLocalPlayerType() == GameManager.PlayerType.Cross)
        {
            crossYouText.SetActive(true);
        } else
        {
            circleYouText.SetActive(true);
        }

        UpdateCurrentArrow();
    }

    private void UpdateCurrentArrow()
    {
        if(GameManager.Instance.GetCurrentPlayablePlayerType() == GameManager.PlayerType.Cross)
        {
            crossArrowTurn.SetActive(true) ;
            circleArrowTurn.SetActive(false) ;
        } else
        {
            crossArrowTurn.SetActive(false) ;
            circleArrowTurn.SetActive(true) ;
        }
    }
}
