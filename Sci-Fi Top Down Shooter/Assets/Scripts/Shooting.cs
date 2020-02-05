using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject BulletPrefab;

    // bullet stats
    public float bulletForce = 20f;
    public int maxAmmo = 15;
    public int clips;
    public int currAmmo;
    public float reloadTime = 1f;
    public bool isReloading = false;

    private string cstring;
    private int indexSpace;
    private string clipsString;


    // UI text stuff
    public Text ammoText;
    public Text clipText;

    void Start()
    {
        currAmmo = maxAmmo;
        ammoText = GameObject.Find("AmmoText").GetComponent<Text>();
        ammoText.text = currAmmo + "/15";
        clips = 45;
        clipText = GameObject.Find("BulletLeftText").GetComponent<Text>();
        clipText.text = clips.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        cstring = clipText.text;
        indexSpace = cstring.IndexOf(" ");
        clipsString = cstring.Substring(indexSpace + 1);
        clips = int.Parse(clipsString);

        // checks if there's any ammo left to reload and reloads if r is pressed and current ammo is not full
        if (clips >= 0)
        {
            if ((currAmmo <= 0))
            {
                if (Input.GetKeyDown(KeyCode.R))
                {
                    Reload();
                }
            }
            else if (Input.GetKeyDown(KeyCode.R) && currAmmo != 15)
            {
                Reload();
            }

            // calls the method shoot if the left mouse button is clicked and the game is not paused
            else if (PauseMenu.GameIsPaused == false && Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }
        
    }

    // shoot method that creates bullet and "shoots" it 
    void Shoot()
    {
        // decrease ammo by 1 and text
        currAmmo--;
        //ammoText.text = "Ammo: " + currAmmo;
        ammoText.text = currAmmo + "/15";

        // instantiates the bullet in front of the gun since thats where the game object was created at  
        GameObject bullet = Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);

        // creates a rigid body variable to the bullet
        Rigidbody2D rbBullet = bullet.GetComponent<Rigidbody2D>();
        

        //add a force to the bullet based on the selected speed; impluse makes in instant
        rbBullet.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }

    // reload method
    void Reload()
    {
        // doesn't reload if clips is equal 0
        if (clips != 0)
        {
            // changes the leftover ammo based how much of the current ammo is used
            clips -= (15 - currAmmo);
            if (clips < 0)
            {
                clips = 0;
            }
            currAmmo = maxAmmo;
            clipText.text = clips.ToString();
            ammoText.text = currAmmo + "/15";
        }

    }
}
