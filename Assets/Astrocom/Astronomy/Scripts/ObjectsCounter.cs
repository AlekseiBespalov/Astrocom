using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsCounter : MonoBehaviour
{
    public int CurrentCountOfObjects = 0;
    public List<GameObject> GameObjects;

    public void ObjectsCountIncrement()
    {
        CurrentCountOfObjects += 1;
    }
    public void ObjectCountDecrement()
    {
        CurrentCountOfObjects -= 1;
    }

    public void CheckObjectCountForGameObjects()
    {
        foreach(GameObject gameObject in GameObjects)
        {
            if (CurrentCountOfObjects == 0)
            {
                gameObject.SetActive(false);
            }
            else if (CurrentCountOfObjects != 0)
            {
                gameObject.SetActive(true);
            }
        }
    }
}
