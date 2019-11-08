using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace GoogleARCore.Examples.ObjectManipulation
{
#if UNITY_EDITOR
    using Input = GoogleARCore.InstantPreviewInput;
#endif
    public class GetInfo : MonoBehaviour
    {
        public string Title;
        public Text Text;

        private void OnMouseDown()
        {
            Touch touch;
            touch = Input.GetTouch(0);
            int pointerID = touch.fingerId;

            if (Input.touchCount == 1 && !EventSystem.current.IsPointerOverGameObject(pointerID))
            {
                GameObject.FindGameObjectWithTag("PlaneDiscovery")
                    .transform.Find("Canvas")
                    .Find("Info")
                    .Find("InfoPanel")
                    .transform.Find("Header")
                    .GetComponent<Text>().text = Title;
                GameObject.FindGameObjectWithTag("PlaneDiscovery")
                    .transform.Find("Canvas")
                    .Find("Info")
                    .Find("InfoPanel")
                    .transform.Find("ScrollArea")
                    .transform.Find("TextContainer")
                    .transform.Find("Text")
                    .GetComponent<Text>().text = Text.text;
            }
            else
            {
                return;
            }
        }
    }
}