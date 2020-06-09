using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchToRay : MonoBehaviour
{
  // Start is called before the first frame update
  bool pieceSelected = false;
  Camera myCamera;
  RaycastHit hit;
  ChessPiece chessPiece;
  void Start()
  {
    myCamera = GetComponent<Camera>();
  }
  // fixed update is once every ~16 milli
  // Update is called once per frame
  void Update()
  {
    if (Input.touches.Length > 0 && Input.touches[0].phase == TouchPhase.Began)
    {
      Ray ray = myCamera.ScreenPointToRay(Input.touches[0].position);
      if (pieceSelected)
      {
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, LayerMask.GetMask("Board")))
        {
          Debug.Log(hit.transform.gameObject.GetComponent<BoardPositionGetter>().position);
          // Set chess piece to object position at this board position
          chessPiece.transform.SetPositionAndRotation(hit.transform.position, chessPiece.transform.rotation);
          chessPiece.transform.position += new Vector3(.000f, .010f, .000f);
          chessPiece.isActive = false;
          pieceSelected = false;
        }

      }
      else
      {
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, LayerMask.GetMask("ChessPiece")))
        {
          string objectHit = hit.transform.ToString();
          Debug.Log(objectHit);
          chessPiece = hit.transform.gameObject.GetComponent<ChessPiece>();
          if (chessPiece != null)
          {

            pieceSelected = true;
            chessPiece.isActive = true;
          }
          else
          {
            Debug.LogError("Could not find ChessPiece component");
          }
        }
      }
    }
  }
}
