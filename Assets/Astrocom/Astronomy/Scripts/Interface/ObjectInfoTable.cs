using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectInfoTable : MonoBehaviour
{
    public TableCreatorScript infoTable;

    public string[] _headersName;
    public string[] _linesName;
    public string[] _linesContent;

    public void CreateInfo()
    {
        infoTable._headersName = _headersName;
        infoTable._linesName = _linesName;
        infoTable._linesContent = _linesContent;
        infoTable.UpdateTable();
    }

    private void OnMouseDown()
    {
        Touch touch;
        touch = Input.GetTouch(0);
        int pointerID = touch.fingerId;

        if (Input.touchCount == 1 && !EventSystem.current.IsPointerOverGameObject(pointerID))
        {
            CreateInfo();
        }
        else
        {
            return;
        }
    }
}
