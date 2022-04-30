

using System;
using AAChartsDotNet;

public class AALevelsElement {
    public String borderColor;
    public String borderDashStyle;
    public float borderWidth;
    public String color;
    public Boolean colorByPoint;
    public AADataLabels dataLabels;
    public String layoutAlgorithm;
    public String layoutStartingDirection;
    public Object level;
    public AAColorVariation colorVariation;
    public float height;


    public AALevelsElement BorderColor(String prop) {
        borderColor = prop;
        return this;
    }

    public AALevelsElement BorderDashStyle(String prop) {
        borderDashStyle = prop;
        return this;
    }

    public AALevelsElement BorderWidth(float prop) {
        borderWidth = prop;
        return this;
    }

    public AALevelsElement Color(String prop) {
        color = prop;
        return this;
    }

    public AALevelsElement ColorByPoint(Boolean prop) {
        colorByPoint = prop;
        return this;
    }

    public AALevelsElement DataLabels(AADataLabels prop) {
        dataLabels = prop;
        return this;
    }

    public AALevelsElement LayoutAlgorithm(String prop) {
        layoutAlgorithm = prop;
        return this;
    }

    public AALevelsElement LayoutStartingDirection(String prop) {
        layoutStartingDirection = prop;
        return this;
    }

    public AALevelsElement Level(Object prop) {
        level = prop;
        return this;
    }

    public AALevelsElement ColorVariation(AAColorVariation prop) {
        colorVariation = prop;
        return this;
    }

    public AALevelsElement Height(float prop) {
        height = prop;
        return this;
    }

}
