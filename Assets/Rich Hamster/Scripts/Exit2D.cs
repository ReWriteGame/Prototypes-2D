using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Exit2D : MonoBehaviour
{
    [SerializeField] private GameObject[] trekkingObj;
    private Collider2D coll;
    private void Start()
    {
        coll = GetComponent<Collider2D>();
        coll.isTrigger = true;

        if (trekkingObj == null) Debug.Log("Trekking Objects not set.");// �� ��������?
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.GetComponent<Hamster>())
        for (int i = 0; i < trekkingObj.Length; i++)
        {
            if (trekkingObj[i] == collision.gameObject)
            {
                actionsAfterGetCoin();
                break;
            }
        }
    }


    public void actionsAfterGetCoin()
    {
        LevelController.Instance.loadNextLevelWrapper();
        print("Exit.");
    }



    public void destroyMe()
    {
        Destroy(gameObject);
    }
}
