
using System;

public class AATreemap {
    public String layoutAlgorithm;
    public Boolean allowTraversingTree;

    public AATreemap LayoutAlgorithm(String prop) {
        layoutAlgorithm = prop;
        return this;
    }

    public AATreemap AllowTraversingTree(Boolean prop) {
        allowTraversingTree = prop;
        return this;
    }
}
