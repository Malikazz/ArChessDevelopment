using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshToSpawnAsChild : MonoBehaviour
{
    public GameObject MeshPrefab;
    public Transform MeshHolder;
    // Start is called before the first frame update
    void Start()
    {
        if (MeshPrefab == null)
        {
            Debug.LogError("Attempted to setup a mesh without a mesh prefab set (you probably didn't mean to put GamePiece into the scene)");
            return;
        }

        var gameObject = Instantiate(MeshPrefab, transform.position, transform.rotation);
        gameObject.transform.SetParent(MeshHolder, false);
    }
}
