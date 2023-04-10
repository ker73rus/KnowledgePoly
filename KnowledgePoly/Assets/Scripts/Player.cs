using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject curCell;
    public int num = 0;
    public int score = 0;

    public void SetCell(GameObject cell)
    {
        curCell = cell;
        transform.parent = curCell.transform;
        switch (num)
        {
            case 0:
                transform.localPosition = new Vector3(-0.25f, 0.2f);
                break;
            case 1:
                transform.localPosition = new Vector3(0.25f, 0.2f);
                break;
            case 2:
                transform.localPosition = new Vector3(-0.25f, -0.3f);
                break;
            case 3:
                transform.localPosition = new Vector3(0.25f, -0.3f);
                break;
        }
    }
    public void NextCell(int k)
    {
        for(int i = 0; i < k; i++)
        {
            SetCell(curCell.GetComponent<CellScript>().nextCell);
        }
    }
}
