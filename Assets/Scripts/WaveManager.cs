using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager instance;

    [SerializeField]
    private float amplitude = 1f;
    [SerializeField]
    private float phase = 1f;
    [SerializeField]
    private float gravity = 9;//-Physics.gravity.y;
    [SerializeField]
    private float timeScale = 1f;
    [SerializeField]
    private float depth = 10f;
    [SerializeField]
    private Vector3 direction = new Vector3(0.1f, 0, 0);

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    public float GetWaveHeight(float _x, float _y, float _z)
    {
        float frequency = Mathf.Sqrt(gravity * direction.magnitude * (float)(System.Math.Tanh(depth * direction.magnitude)));
        float theta = (_x * direction.x) + (_z * direction.z) - frequency * (Time.time * timeScale) - phase;

        //float X = (-(Mathf.Sin(theta) * ((direction.x / direction.magnitude) * (amplitude / (float)System.Math.Tanh(direction.magnitude * depth)))));
        float Y = Mathf.Cos(theta) * amplitude;
        //float Z = ((Mathf.Sin(theta) * ((direction.z / direction.magnitude) * (amplitude / (float)System.Math.Tanh(direction.magnitude * depth)))));

        return Y;
    }
}
