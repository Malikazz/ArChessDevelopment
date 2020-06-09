using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPiece : MonoBehaviour
{
  // Start is called before the first frame update
  public bool isActive { get; set; }
  public GameObject blueMarker;
  void Start()
  {
    isActive = false;
  }

  // Update is called once per frame
  void Update()
  {
    blueMarker.SetActive(isActive);
  }
}
