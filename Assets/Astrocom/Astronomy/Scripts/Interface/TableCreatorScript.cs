using UnityEngine;
using UnityEngine.UI;

public class TableCreatorScript : MonoBehaviour
{
    // INSPECTOR SETTINGS

    public string[] _headersName;
    public string[] _linesName;
    public string[] _linesContent;
    public GameObject _tableObject;
    public Transform _tableObjectParent;

    // Start headers and lines with offset
    int tableOffset;

    //Start is called before the first frame update
    void Start()
    {
        tableOffset = _headersName.Length + 1;
        // Set columns count
        _tableObjectParent.GetComponent<GridLayoutGroup>().constraintCount = tableOffset;

        UpdateTable();
    }

    public void UpdateTable()
    {
        tableOffset = _headersName.Length + 1;
        // Set columns count
        _tableObjectParent.GetComponent<GridLayoutGroup>().constraintCount = tableOffset;

        // If table already exist...
        if (_tableObjectParent.childCount > 0)
            // Destroy all table objects
            for (int i = 0; i < _tableObjectParent.childCount; i++)
                Destroy(_tableObjectParent.GetChild(i).gameObject);

        // Create headers
        for (int i = 0; i < tableOffset; i++)
        {
            GameObject newHeader = Instantiate(_tableObject, _tableObjectParent);

            if (i == 0) continue;

            newHeader.GetComponentInChildren<Text>().text = _headersName[i - 1];
        }

        // Create lines
        for (int i = 0; i < (_linesName.Length * _headersName.Length) + _linesName.Length; i++)
        {
            GameObject newLine = Instantiate(_tableObject, _tableObjectParent);

            if (i % tableOffset == 0)
                newLine.GetComponentInChildren<Text>().text = _linesName[i / tableOffset];
            else
            {
                newLine.GetComponentInChildren<Text>().text = _linesContent[i - 1];
            }
        }
    }

}