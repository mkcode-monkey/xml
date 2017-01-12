using UnityEngine;
using System.Collections;

public class UIStoreItem : MonoBehaviour {

    private Transform m_Transform;

    private UILabel label_Name;

    private GameObject button_Buy;
    private GameObject button_Play;

	void Awake () {
        m_Transform = gameObject.GetComponent<Transform>();
        label_Name = m_Transform.Find("Name").GetComponent<UILabel>();
        button_Buy = m_Transform.Find("Button_Buy").gameObject;
        button_Play = m_Transform.Find("Button_Play").gameObject;

	}
	
    public void InitStoreItem(StoreItem storeItem)
    {
        label_Name.text = storeItem.Name;
        if(storeItem.Active)
        {
            button_Buy.SetActive(false);
            button_Play.SetActive(true);
        }
        else
        {
            button_Buy.SetActive(true);
            button_Play.SetActive(false);
        }
    }
}
