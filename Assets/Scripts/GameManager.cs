using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState { Menu, Tutorial }
public class GameManager : MonoBehaviour
{
    public GameState state;

    public Action<GameState> OnStateChanged;

    private void Awake()
    {
        UpdateState(GameState.Menu);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateState(GameState newState) 
    {
        this.state = newState;
        switch (state)
        {
            case GameState.Menu:
                SceneManager.LoadScene("Menu");
                break;
            case GameState.Tutorial:
                SceneManager.LoadScene("Tutorial");
                break;
            default:
                throw new NotImplementedException();
        }

        OnStateChanged?.Invoke(state);
    }
}
