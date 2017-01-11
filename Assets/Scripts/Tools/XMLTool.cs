using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

/// <summary>
/// XML工具类.负责读取和存储XML文件.
/// </summary>
public static class XMLTool{

    /// <summary>
    /// 通过指定路径读取XML文件中的数据.
    /// </summary>
    /// <param name="path">xml文件路径</param>
    /// <param name="list">用于存储数据的集合</param>
    public static void ReadXMLByPath(string path, List<StoreItem> list)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(path);
        //获取根节点.
        XmlNode rootNode = doc.SelectSingleNode("StoreData");
        //获取根节点下所有子节点.
        XmlNodeList nodeList = rootNode.ChildNodes;
        
        //遍历子节点集合.
        foreach(XmlNode node in nodeList)
        {
            int id = int.Parse(node.ChildNodes[0].InnerText);
            string name = node.ChildNodes[1].InnerText;
            int gold = int.Parse(node.ChildNodes[2].InnerText);
            string model = node.ChildNodes[3].InnerText;
            bool active = bool.Parse(node.ChildNodes[4].InnerText);

            StoreItem item = new StoreItem(id, name, gold, model, active);
            list.Add(item);
        }

    }

    /// <summary>
    /// 保存数据集合到指定位置的XML文件中.
    /// </summary>
    /// <param name="list">数据集合</param>
    /// <param name="path">XML文件路径</param>
    /// <returns>是否存储成功</returns>
    public static bool SaveXMLByList(List<StoreItem> list, string path)
    {

        return false;
    }
}




