using System;


public class AADataClassesElement {
    public float from;
    public float to;
    public Object color;
    public String name;

    public AADataClassesElement From(float prop) {
        from = prop;
        return this;
    }

    public AADataClassesElement To(float prop) {
        to = prop;
        return this;
    }

    public AADataClassesElement Color(Object prop) {
        color = prop;
        return this;
    }

    public AADataClassesElement Name(String prop) {
        name = prop;
        return this;
    }

}
