using UnityEngine;
using System.Collections;

public class BaseScript : MonoBehaviour
{
    #region Fields

    /// <summary>
    /// The main camera.
    /// </summary>
    protected Camera mainCamera;
    /// <summary>
    /// The player object.
    /// </summary>
    protected GameObject player;

    #endregion

    #region Methods

    /// <summary>
    /// Called when game awake.
    /// </summary>
    void Awake()
    {
        Initialize();
    }

    /// <summary>
    /// Initialize global variables.
    /// </summary>
    protected void Initialize()
    {
        // Get main camera.
        mainCamera = Camera.main;

        // Get player.
        player = GameObject.FindGameObjectWithTag(GameSettings.PlayerTag);
    }

    #endregion
}