using UnityEngine;
using System.Collections;

/// <summary>
/// 商场UI界面主管理器.
/// </summary>
public class UIStoreManager : MonoBehaviour {

    private GameObject prefab_StoreItem;
    private string prefabPath_StoreItem;

	void Start () {
        prefab_StoreItem = Resources.Load<GameObject>(prefabPath_StoreItem);
	}
	
	void Update () {
	
	}
}
