﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject BulletPrefab;

    // bullet stats
    public float bulletForce = 20f;
    //public float damage = 20f;
    public int maxAmmo = 15;
    public int clips;
    public int currAmmo;
    public float reloadTime = 1f;
    public bool isReloading = false;

    private string cstring;
    //private int currClips;
    private int indexSpace;
    private string clipsString;


    // UI text stuff
    public Text ammoText;
    public Text clipText;

    void Start()
    {
        currAmmo = maxAmmo;
        ammoText = GameObject.Find("AmmoText").GetComponent<Text>();
        ammoText.text = "Ammo: " + currAmmo;
        clips = 3;
        clipText = GameObject.Find("ClipText").GetComponent<Text>();
        clipText.text = "Clips: " + clips;
    }

    // Update is called once per frame
    void Update()
    {

        cstring = clipText.text;
        indexSpace = cstring.IndexOf(" ");
        clipsString = cstring.Substring(indexSpace + 1);
        clips = int.Parse(clipsString);

        if (clips >= 0)
        {
            if ((currAmmo <= 0))
            {
                if (Input.GetKeyDown(KeyCode.R))
                {
                    Reload();
                }
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                Reload();
            }

            // calls the method shoot if the left mouse button is clicked 
            else if (Input.GetButtonDown("Fire1"))
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
        ammoText.text = "Ammo: " + currAmmo;

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
            currAmmo = maxAmmo;
            ammoText.text = "Ammo: " + currAmmo;
            clips--;
            clipText.text = "Clips: " + clips;
        }

    }
}