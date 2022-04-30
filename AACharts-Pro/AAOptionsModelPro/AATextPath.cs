using System;
using System.Collections.Generic;

public class AATextPath {
    public Boolean enabled;
    public Dictionary<string, object> attributes;

    public AATextPath Enabled(Boolean prop) {
        enabled = prop;
        return this;
    }

    public AATextPath Attributes(Dictionary<string, object> prop) {
        attributes = prop;
        return this;
    }

}
