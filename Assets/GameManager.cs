using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PipesHolder;
    public GameObject[] PuzzlePieces;

    [SerializeField]
    int TotalPipeNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        TotalPipeNumber = PipesHolder.transform.childCount;

        PuzzlePieces = new GameObject[TotalPipeNumber]; 

        for (int i = 0; i < PuzzlePieces.Length; i++)
        {
            PuzzlePieces[i] = PuzzlePieces.transform.GetChild(i).GameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
