using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public Score_Script scoreManager;

    private void OncollisionEnter(Collision collision)
    {
        scoreManager.AddPoint();

        Debug.Log("Collision detected");
        Destroy(gameObject);
    }
}
