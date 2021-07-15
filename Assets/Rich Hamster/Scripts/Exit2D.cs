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

        if (trekkingObj == null) Debug.Log("Trekking Objects not set.");// не работает?
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.GetComponent<Hamster>())
        foreach (GameObject obj in trekkingObj)
        {
            if (obj == collision.gameObject)
            {
                actionsAfterGetting();
                break;
            }
        }
    }


    public void actionsAfterGetting()
    {
        LevelController.Instance.loadNextLevelWrapper();
        print("Exit.");
    }



    public void destroyMe()
    {
        Destroy(gameObject);
    }
}
