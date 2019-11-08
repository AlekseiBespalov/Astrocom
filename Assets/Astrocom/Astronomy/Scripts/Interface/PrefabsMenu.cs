using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoogleARCore.Examples.ObjectManipulation
{
    public class PrefabsMenu : MonoBehaviour
    {
        //-1 haven't respawned objects, !=-1 object is chosen
        public int ChosenPrefab = -1;

        public void ChoosePrefab(int PrefabNumber)
        {
            ChosenPrefab = PrefabNumber;
            Debug.Log("Prefab number chosen is " + ChosenPrefab);
        }
    }
}
