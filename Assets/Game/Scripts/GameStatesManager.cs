using UnityEngine;
using System.Collections;
using System;

/*
 * ゲームの進行管理を扱うクラス．
 * 画面状態を保持し，遷移する場合はコールバック関数を呼び出す．
 */
public class GameStatesManager : MonoBehaviour {
    // ゲームの画面状態（MAIN:メイン画面，RESULT:結果画面，GAMEOVER，ゲームオーバー画面）
    public enum GameState
    {
        MAIN, RESULT, GAMEOVER
    }

    // 現在のゲームの状態
    GameState currentGameState = GameState.MAIN;

    // メイン画面状態の遷移時コールバック
    public event Action calledToMain = () => { };

    // 結果画面状態の遷移時コールバック
    public event Action calledToResult = () => { };

    // ゲームオーバー画面状態の遷移時コールバック
    public event Action calledToGameOver = () => { };


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        switch (currentGameState)
        {
            case GameState.MAIN:
                UpdateMain();
            break;
            case GameState.RESULT:
                UpdateResult();
            break;
            case GameState.GAMEOVER:
                UpdateGameOver();
            break;
        }
	
	}

    // 現在の画面状態を返す．
    public GameState getCurrentGameState()
    {
        return currentGameState;
    }

    // メイン画面に遷移させる．対応するコールバック関数を呼び出す．
    public void ToMain()
    {
        calledToMain();
        currentGameState = GameState.MAIN;
    }

    // 結果画面に遷移させる．対応するコールバック関数を呼び出す．
    public void ToResult()
    {
        calledToResult();
        currentGameState = GameState.RESULT;
    }

    // ゲームオーバー画面に遷移させる．対応するコールバック関数を呼び出す．
    public void ToGameOver()
    {
        calledToGameOver();
        currentGameState = GameState.GAMEOVER;
    }

    // メイン画面時フレーム更新ごとに呼ばれる．
    void UpdateMain()
    {

    }

    // 結果画面時フレーム更新ごとに呼ばれる．
    void UpdateResult()
    {

    }

    // ゲームオーバー画面時フレーム更新ごとに呼ばれる．
    void UpdateGameOver()
    {

    }
}
