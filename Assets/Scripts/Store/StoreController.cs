using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// 商场主控制器.
/// </summary>
public class StoreController : MonoBehaviour {
    
    /// <summary>
    /// 商城数据实体集合.
    /// </summary>
    public List<StoreItem> storeItemList = new List<StoreItem>();

    public List<StoreItem> Store
    {
        get { return storeItemList; }
    }

    /// <summary>
    /// 初始化实体数据集合.
    /// </summary>
    public void InitStoreItemList()
    {
        //xml文件路径.
        string xmlPath = "Assets/Datas/StoreData.xml";
        //读取XML中的信息到集合中.
        XMLTool.ReadXMLByPath(xmlPath, storeItemList);

        for (int i = 0; i < storeItemList.Count; i++)
        {
            string str = storeItemList[i].ToString();
            Debug.Log(str);
        }
    }


    void Awake()
    {
        InitStoreItemList();
    }

}
