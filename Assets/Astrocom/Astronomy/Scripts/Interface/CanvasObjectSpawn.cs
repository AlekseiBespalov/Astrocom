using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoogleARCore.Examples.ObjectManipulation
{
    public class CanvasObjectSpawn : MonoBehaviour
    {
        public ManipulationSystem manipulation;
        public Camera canvasCamera;
        public GameObject panel;
        public void SpawnCanvasObject()
        {
            var ObjectToSpawn = manipulation.SelectedObject;

            Vector3 cameraPosition = canvasCamera.transform.position;
            Vector3 spawnPosition = cameraPosition + new Vector3(0f, 0f, 100f);

            var spawnedObject = Instantiate(ObjectToSpawn, spawnPosition, canvasCamera.transform.rotation) as GameObject;
            spawnedObject.transform.parent = panel.transform;
            spawnedObject.transform.localScale += new Vector3(-0.95f, -0.95f, -0.95f);
            spawnedObject.transform.position = spawnPosition;
        }
    }
}
