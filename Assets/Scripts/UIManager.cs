using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class UIManager : MonoBehaviour
{
    public ScoreManager scoreManager;
    public Tilemap boardTilemap;

    public void Restart()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
        GameObject boardObject = GameObject.Find("Board");
        Tilemap boardTilemap = boardObject.GetComponentInChildren<Tilemap>();
        boardTilemap.ClearAllTiles();
        scoreManager.ResetScore();
        Debug.LogError("Restart button worked");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.LogError("Quit button worked");
    }
}
