
using System;

public class AALayoutAlgorithm {

    public float gravitationalConstant;
    public Boolean splitSeries;
    public Boolean seriesInteraction;
    public Boolean dragBetweenSeries;
    public Boolean parentNodeLimit;

    public AALayoutAlgorithm GravitationalConstant(float prop) {
        gravitationalConstant = prop;
        return this;
    }

    public AALayoutAlgorithm SplitSeries(Boolean prop) {
        splitSeries = prop;
        return this;
    }

    public AALayoutAlgorithm SeriesInteraction(Boolean prop) {
        seriesInteraction = prop;
        return this;
    }

    public AALayoutAlgorithm DragBetweenSeries(Boolean prop) {
        dragBetweenSeries = prop;
        return this;
    }

    public AALayoutAlgorithm ParentNodeLimit(Boolean prop) {
        parentNodeLimit = prop;
        return this;
    }


}
