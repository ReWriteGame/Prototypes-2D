using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Coin2D : MonoBehaviour
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
        ScoreCounter.Instance.incScore();
        print("Get Coin.");
        destroyMe();
    }



    public void destroyMe()
    {
        Destroy(gameObject);
    }
}
