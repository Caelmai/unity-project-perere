using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenericPooling : BaseScript
{
    #region Fields

    /// <summary>
    /// The prefab.
    /// </summary>
    [SerializeField]
    protected GameObject prefab;

    /// <summary>
    /// The initial size of pool.
    /// </summary>
    [SerializeField]
    private int poolSize = 0;
    /// <summary>
    /// If pool can grow or not.
    /// </summary>
    [SerializeField]
    private bool poolCanGrow = false;
    /// <summary>
    /// A pool of prefab object.
    /// </summary>
    private List<GameObject> pool = new List<GameObject>();

    #endregion

    #region Methods

    /// <summary>
    /// Called when script start.
    /// </summary>
    void Start()
    {
        StartingPool();
    }

    /// <summary>
    /// Initializes pool.
    /// </summary>
    private void StartingPool()
    {
        if (prefab == null)
        {
            Debug.LogError("Has not been defined a prefab!");
        }

        for (int i = 0; i < poolSize; i++)
        {
            CreateNewObject();
        }
    }

    /// <summary>
    /// Get a game object from pool.
    /// </summary>
    /// <param name="position">The positoin.</param>
    /// <param name="active">Is if active or not.</param>
    /// <returns>Returns a game object from pool.</returns>
    public GameObject GetObjectFromPool(Vector2 position, Quaternion rotation, bool active = true)
    {
        foreach (GameObject obj in pool)
        {
            if (!obj.activeInHierarchy)
            {
                return PrepareObjectToResponse(obj, position, rotation, active);
            }
        }

        if (poolCanGrow)
        {
            GameObject obj = CreateNewObject();

            return PrepareObjectToResponse(obj, position, rotation, active);
        }

        return null;
    }

    /// <summary>
    /// Creates a new game object.
    /// </summary>
    /// <returns>Returns a new game object.</returns>
    private GameObject CreateNewObject()
    {
        GameObject newObject = Instantiate(prefab) as GameObject;
        newObject.SetActive(false);

        pool.Add(newObject);

        return newObject;
    }

    /// <summary>
    /// Prepare a game object to response.
    /// </summary>
    /// <param name="obj">The game object.</param>
    /// <param name="position">The position.</param>
    /// <param name="active">Is is active or not.</param>
    /// <returns>Returns the game object.</returns>
    private GameObject PrepareObjectToResponse(GameObject obj, Vector2 position, Quaternion rotation, bool active)
    {
        obj.transform.position = position;
        obj.transform.rotation = rotation;
        obj.SetActive(active);

        return obj;
    }

    #endregion
}
