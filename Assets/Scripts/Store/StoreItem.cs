using UnityEngine;
using System.Collections;

/// <summary>
/// 商场物品数据实体.
/// </summary>
public class StoreItem{
    private int id;     //商品id.
    private string name;//商品名称.
    private int gold;   //商品售价.
    private string model;//商场元素预制体名称.
    private bool active; //是否激活,true已购买,false未购买.

    /// <summary>
    /// 构造实体数据.
    /// </summary>
    public StoreItem(int id, string name, int gold, string model, bool active)
    {
        this.id = id;
        this.name = name;
        this.gold = gold;
        this.model = model;
        this.active = active;
    }

    /// <summary>
    /// 空构造.
    /// </summary>
    public StoreItem() { }


    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Gold
    {
        get { return gold; }
        set { gold = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public bool Active
    {
        get { return active; }
        set { active = value; }
    }

    public override string ToString()
    {
        string storeItemStr = string.Format("ID:{0} - 名称:{1} - 售价:{2} - 模型:{3} - 激活状态:{4}", this.id, this.name, this.gold, this.model, this.active);
        return storeItemStr;
    }
}
