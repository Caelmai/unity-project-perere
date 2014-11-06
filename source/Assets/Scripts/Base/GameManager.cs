using UnityEngine;
using System.Collections;

public class GameManager : BaseScript
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

    /// <summary>
    /// The player movement script.
    /// </summary>
    public PlayerMovement PlayerMovementScript;

    /// <summary>
    /// The player health script.
    /// </summary>
    public PlayerHealth PlayerHealthScript;

    /// <summary>
    /// The player weapon script.
    /// </summary>
    public PlayerWeapon PlayerWeaponScript;

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

        PlayerMovementScript = PlayerObject.GetComponent<PlayerMovement>();
        PlayerHealthScript = PlayerObject.GetComponent<PlayerHealth>();
        PlayerWeaponScript = PlayerObject.GetComponentInChildren<PlayerWeapon>();
    }

    #endregion
}