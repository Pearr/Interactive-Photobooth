using UnityEngine;
using System.Collections;
using UnityEngine.UI;
[ExecuteInEditMode]
[RequireComponent(typeof(GridLayoutGroup))]


public class DynamicBottomBar : MonoBehaviour
{

    public int col, row;


    void Update()
    {
        RectTransform Bottom_Nav_Panel = gameObject.GetComponent<RectTransform>();
        GridLayoutGroup grid = gameObject.GetComponent<GridLayoutGroup>();

        grid.cellSize = new Vector2(Bottom_Nav_Panel.rect.width / col, Bottom_Nav_Panel.rect.height / row);
    }
}