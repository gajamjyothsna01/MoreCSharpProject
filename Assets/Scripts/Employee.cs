using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Employee : MonoBehaviour 
{
    public string employeeName;
  
    public string companyName = "PurpleTalk";

    public abstract void MonthlySalary();

}

