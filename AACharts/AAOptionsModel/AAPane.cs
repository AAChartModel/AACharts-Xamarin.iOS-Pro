namespace AAChartsDotNet
{
    public class AAPane {
        public AABackground background;
        public object[] center;
        public float endAngle;
        public float size;
        public float startAngle;

        public AAPane Background(AABackground prop) {
            background = prop;
            return this;
        }

        public AAPane Center(object[] prop) {
            center = prop;
            return this;
        }

        public AAPane EndAngle(float prop) {
            endAngle = prop;
            return this;
        }

        public AAPane Size(float prop) {
            size = prop;
            return this;
        }

        public AAPane StartAngle(float prop) {
            startAngle = prop;
            return this;
        }
    }
    
    public class AABackground {
        public object backgroundColor;
        public string borderColor;
        public float borderWidth;
        public string className;
        public float innerRadius;
        public float outerRadius;
        public string shape;

        public AABackground BackgroundColor(object prop) {
            backgroundColor = prop;
            return this;
        }
        public AABackground BorderColor(string prop) {
            borderColor = prop;
            return this;
        }

        public AABackground BorderWidth(float prop) {
            borderWidth = prop;
            return this;
        }

        public AABackground ClassName(string prop) {
            className = prop;
            return this;
        }

        public AABackground InnerRadius(float prop) {
            innerRadius = prop;
            return this;
        }

        public AABackground OuterRadius(float prop) {
            outerRadius = prop;
            return this;
        }

        public AABackground Shape(string prop) {
            shape = prop;
            return this;
        }

    }


}