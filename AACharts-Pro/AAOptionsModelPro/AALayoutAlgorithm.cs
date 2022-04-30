
using System;

public class AALayoutAlgorithm {

    public object gravitationalConstant;
    public object splitSeries;
    public object seriesInteraction;
    public object dragBetweenSeries;
    public object parentNodeLimit;

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
