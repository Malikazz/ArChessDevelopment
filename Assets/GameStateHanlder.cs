using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateHanlder : MonoBehaviour
{
  // Start is called before the first frame update
  private PiecesEnum[] gameState = new PiecesEnum[64];

  PiecesEnum getPiecesEnum(int arrayIndex)
  {
    return gameState[arrayIndex];
  }
  void setPiecesEnum(int arrayIndex, PiecesEnum piece)
  {
    gameState[arrayIndex] = piece;
  }

  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }
}
