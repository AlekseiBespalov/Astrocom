using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GoogleARCore.Examples.ObjectManipulation
{
    public class GetInfoTableImage : MonoBehaviour
    {
        public Sprite tableImage;

        private void OnMouseDown()
        {
            Touch touch;
            touch = Input.GetTouch(0);
            int pointerID = touch.fingerId;

            if (Input.touchCount == 1 && !EventSystem.current.IsPointerOverGameObject(pointerID))
            {
                GameObject.FindGameObjectWithTag("PlaneDiscovery").transform.Find("Canvas")
                    .Find("Info").Find("InfoTableImage").transform.Find("ImageRoot").GetComponent<Image>().sprite = tableImage;
            }
            else
            {
                return;
            }

            //GameObject.FindGameObjectWithTag("PlaneDiscovery").transform.Find("Canvas")
            //    .Find("Info").Find("InfoTableImage").transform.Find("ImageRoot").GetComponent<Image>().sprite = tableImage;
        }
    }
}
