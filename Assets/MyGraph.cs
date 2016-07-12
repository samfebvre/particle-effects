using UnityEngine;
using System.Collections;

public class MyGraph : MonoBehaviour
{

    [Range(2, 2)]
    public int resolution = 2;

    private int currentResolution;
    private ParticleSystem.Particle[] points;


    // Use this for initialization
    void Start()
    {
        CreatePoints();
    }

    private void CreatePoints()
    {
        currentResolution = resolution;
        points = new ParticleSystem.Particle[resolution];
        float increment = 1f / (resolution - 1);
        for (int i = 0; i < resolution; i++)
        {
            float x = i * increment;
            points[i].position = new Vector3(0f, 0f, 0f);
            points[i].startColor = new Color(1f, 0.1f, 0f);
            points[i].startSize = 0.5f;
            //points[i].rotation = 10f * i;
        }

    }


    // Update is called once per frame
    void Update()
    {
        if (currentResolution != resolution || points == null)
        {
            CreatePoints();
        }
        for (int i = 0; i < resolution; i++)
        {
            Vector3 p = points[i].position;
            //p.y = (p.x);
            points[i].position = p;
        }
        GetComponent<ParticleSystem>().SetParticles(points, points.Length);


    }


}
