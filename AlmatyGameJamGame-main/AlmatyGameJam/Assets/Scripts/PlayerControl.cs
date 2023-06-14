using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public static PlayerControl instance;

    float moveHor;
    float moveVer;
    public int speed = 2;
    public Rigidbody2D playerRB;
    public bool isFacingRight = true;
    public Animator animator;
    public GameObject bullet;
    public GameObject koltd;
    public GameObject kol1;
    public GameObject kol2;
    public GameObject kol3;
    public bool startnpc;
    public LegensFollow lf;
    private bool isRKeyPressed = false;

    public GameObject mainScene;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        koltd.SetActive(false);
        kol1.SetActive(true);
        kol2.SetActive(true);
        kol3.SetActive(true);
        startnpc = false;
    }

    void Update()
    {
        moveHor = Input.GetAxis("Horizontal");
        moveVer = Input.GetAxis("Vertical");

        if (moveHor > 0 && !isFacingRight)
        {
            Flip();
        }
        else if (moveHor < 0 && isFacingRight)
        {
            Flip();
        }

        if (startnpc == false)
        {
            lf.lineOfSite = 0;
        }
        else
        {
            lf.lineOfSite = 10;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            isRKeyPressed = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }

        if (Input.GetKey(KeyCode.G))
        {
            Camera.main.fieldOfView = 150f;
        }
        else 
        {
            Camera.main.fieldOfView = 60f;
        }
    }

    private void FixedUpdate()
    {
        playerRB.velocity = new Vector2(moveHor * speed, moveVer * speed);
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Koltr") && isRKeyPressed)
        {
            ActivateKoltd();
            print("koltausar");
        }
        else if (collision.gameObject.CompareTag("Jelr") && isRKeyPressed)
        {
            OpJelScene();
            print("jelaiaq");
        }
        else if (collision.gameObject.CompareTag("Tolr") && isRKeyPressed)
        {
            OpTolScene();
            print("tolagai");
        }
    }

    void ActivateKoltd()
    {
        koltd.SetActive(true);
        StartCoroutine(DeactivateKoltd(2f));
        StartCoroutine(DeactivateKol1(2.5f));
        StartCoroutine(DeactivateKol2(3f));
        StartCoroutine(DeactivateKol3(3.5f));
        startnpc = true;
        isRKeyPressed = false;
    }

    IEnumerator DeactivateKoltd(float delay)
    {
        yield return new WaitForSeconds(delay);
        koltd.SetActive(false);
    }

    IEnumerator DeactivateKol1(float delay)
    {
        yield return new WaitForSeconds(delay);
        kol1.SetActive(false);
    }

    IEnumerator DeactivateKol2(float delay)
    {
        yield return new WaitForSeconds(delay);
        kol2.SetActive(false);
    }

    IEnumerator DeactivateKol3(float delay)
    {
        yield return new WaitForSeconds(delay);
        kol3.SetActive(false);
        lf.npcwait = false;
    }

    public void OpJelScene()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
        isRKeyPressed = false;
        GameManager.instance.OnSceneLoaded();
    }
    public void OpTolScene()
    {
        SceneManager.LoadScene("MiniGame");
        Time.timeScale = 1;
        isRKeyPressed = false;
        GameManager.instance.OnSceneLoaded();
    }

}
