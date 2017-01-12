using UnityEngine;
using System.Collections;

/// <summary>
/// 商场UI界面主管理器.
/// </summary>
public class UIStoreManager : MonoBehaviour {

    public GameObject prefab_StoreItem;
    private string prefabPath_StoreItem;

    private GameObject ui_StoreArea;
    private UIGrid ui_Grid;

    private StoreController storeController;

	void Start () {
        //prefab_StoreItem = Resources.Load<GameObject>(prefabPath_StoreItem);
        ui_StoreArea = GameObject.Find("UI_StoreArea");
        ui_Grid = ui_StoreArea.GetComponent<UIGrid>();
        storeController = gameObject.GetComponent<StoreController>();
        
        InitUI();
	}


    void InitUI()
    {
        for (int i = 0; i < storeController.storeItemList.Count; i++)
        {
            //GameObject storeItem = GameObject.Instantiate(prefab_StoreItem) as GameObject;
            GameObject item = NGUITools.AddChild(ui_StoreArea, prefab_StoreItem);
            item.SendMessage("InitStoreItem", storeController.storeItemList[i]);
            //item.GetComponent<UIStoreItem>().InitStoreItem(storeController.storeItemList[i]);
            ui_Grid.AddChild(item.transform);
        }
    }

	void Update () {
	
	}
}
