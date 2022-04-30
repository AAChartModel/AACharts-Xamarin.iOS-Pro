

using System;
using AAChartsDotNet;

public class AAPackedbubble {
    public String minSize;
    public String maxSize;
    public float zMin;
    public float zMax;
    public AALayoutAlgorithm layoutAlgorithm;
    public AADataLabels dataLabels;
    public Boolean useSimulation;

    public AAPackedbubble MinSize(String prop) {
        minSize = prop;
        return this;
    }

    public AAPackedbubble MaxSize(String prop) {
        maxSize = prop;
        return this;
    }

    public AAPackedbubble ZMin(float prop) {
        zMin = prop;
        return this;
    }

    public AAPackedbubble ZMax(float prop) {
        zMax = prop;
        return this;
    }

    public AAPackedbubble LayoutAlgorithm(AALayoutAlgorithm prop) {
        layoutAlgorithm = prop;
        return this;
    }

    public AAPackedbubble DataLabels(AADataLabels prop) {
        dataLabels = prop;
        return this;
    }

    public AAPackedbubble UseSimulation(Boolean prop) {
        useSimulation = prop;
        return this;
    }

}
