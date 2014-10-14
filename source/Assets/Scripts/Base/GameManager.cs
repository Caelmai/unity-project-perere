using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    #region Fields

    /// <summary>
    /// Singleton.
    /// </summary>
    private static GameManager instance;

    /// <summary>
    /// The main camera.
    /// </summary>
    public Camera MainCamera;

    /// <summary>
    /// The player game object.
    /// </summary>
    public GameObject PlayerObject;

    #endregion

    #region Properties

    public static GameManager Instance
    {
        get
        {
            if (GameManager.instance == null)
            {
                GameManager.instance = GameObject.FindObjectOfType<GameManager>();
            }

            return GameManager.instance;
        }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Called when game start.
    /// </summary>
    void Awake()
    {
        MainCamera = Camera.main;

        PlayerObject = GameObject.FindGameObjectWithTag(GameSettings.PlayerTag);
    }

    #endregion
}