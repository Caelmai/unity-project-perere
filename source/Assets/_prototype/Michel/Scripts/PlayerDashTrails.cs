using UnityEngine;
using System.Collections;

public class PlayerDashTrails : MonoBehaviour
{
    public static PlayerDashTrails Self;

    [SerializeField]
    private float trailDuration;

    /// <summary>
    /// 
    /// </summary>
    private TrailRenderer dashTrail;

    // TEMPO DE DURACAO DO DASH
    private float dashTimer;

    // VARIACAO EM Y DURANTE O MOVIMENTO PARA DAR UMA LEVE VIBRACAO NO TRAIL
    private float yOffset;

    void Awake()
    {
        Self = this;

        dashTrail = GetComponent<TrailRenderer>();
    }

    void Start()
    {
        dashTrail.time = -1;
    }

    // Update is called once per frame
    void Update()
    {

        // CONTA O TEMPO DO DASH. SE PASSAR DO SETADO, ACABA
        if (dashTimer > 0)
        {
            dashTimer -= Time.deltaTime;
        }
        else
        {
            dashTrail.time = -1;
        }

        // EXECUTA VARIACAO
        yOffset = Random.Range(-0.025f, 0.025f);
        transform.position = new Vector2(transform.parent.transform.position.x, transform.parent.transform.position.y + yOffset);
    }

    /// <summary>
    /// 
    /// </summary>
    public void Dash()
    {
        dashTimer = trailDuration;
        dashTrail.time = trailDuration;
    }
}
