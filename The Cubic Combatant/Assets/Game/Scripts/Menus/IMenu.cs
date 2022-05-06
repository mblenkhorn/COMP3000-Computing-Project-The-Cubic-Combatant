using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMenu 
{
    public void open(GameObject menuToOpen);

    public void close(GameObject menuToClose);
}
