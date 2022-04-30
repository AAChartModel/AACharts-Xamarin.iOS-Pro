
using System;

public class AAColorAxis {
    public float min;
    public String minColor;
    public String maxColor;
    public AADataClassesElement[] dataClasses;


    public AAColorAxis Min(float prop) {
        min = prop;
        return this;
    }

    public AAColorAxis MinColor(String prop) {
        minColor = prop;
        return this;
    }

    public AAColorAxis MaxColor(String prop) {
        maxColor = prop;
        return this;
    }

    public AAColorAxis DataClasses(AADataClassesElement[] prop) {
        dataClasses = prop;
        return this;
    }
    
    
}
