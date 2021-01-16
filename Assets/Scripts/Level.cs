using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int numBlocks; // serialized for debugging purposes

    SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlock()
    {
        numBlocks++;
    }
    public void decrementBlocks()
    {
        numBlocks--;
        if(numBlocks == 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
