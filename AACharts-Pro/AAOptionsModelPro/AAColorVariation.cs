
using System;

public class AAColorVariation {
    public String key;
    public float to;


    public AAColorVariation Key(String prop) {
        key = prop;
        return this;
    }

    public AAColorVariation To(float prop) {
        to = prop;
        return this;
    }
}
