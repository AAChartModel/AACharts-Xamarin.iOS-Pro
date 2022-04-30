
using System;

public class AAFilter {
    public String property;
    public String _operator;
    public float value;

    public AAFilter Property(String prop) {
        property = prop;
        return this;
    }

    public AAFilter Operator(String prop) {
        _operator = prop;
        return this;
    }

    public AAFilter Value(float prop) {
        value = prop;
        return this;
    }

}
